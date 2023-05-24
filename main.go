package main

import (
	"bufio"
	"flag"
	"io/ioutil"
	"math/rand"
	"net/http"
	"os"
	"regexp"
	"strconv"
	"strings"
	"time"
	"unsafe"

	"github.com/pterm/pterm"
)

const (
	leIndexBits = 6
	leIndexMask = 1<<leIndexBits - 1
	leIndexMax  = 63 / leIndexBits
)

var rn = time.Now().String()

var src = rand.NewSource(time.Now().UnixNano())

func trueRand(n int, chars string) string {
	b := make([]byte, n)
	for i, cache, remain := n-1, src.Int63(), leIndexMax; i >= 0; {
		if remain == 0 {
			cache, remain = src.Int63(), leIndexMax
		}
		if idx := int(cache & leIndexMask); idx < len(chars) {
			b[i] = chars[idx]
			i--
		}
		cache >>= leIndexBits
		remain--
	}

	return *(*string)(unsafe.Pointer(&b))
}

func retrieveRaw(url string, filtertype int, filtercontent string, outtputtype int, logger *pterm.Logger) {
	method := "GET"
	client := &http.Client{}
	req, err := http.NewRequest(method, url, nil)

	if err != nil {
		logger.Error(err.Error())
	}
	res, err := client.Do(req)
	if err != nil {
		logger.Error(err.Error())
	}

	defer res.Body.Close()

	if res.StatusCode == 200 {
		switch filtertype {
		case 0:
			logger.Info("MATCH", logger.Args("URL", url))
			if outtputtype == 1 {
				write(url, rn, logger)
			}
		case 1:
			body, err := ioutil.ReadAll(res.Body)
			if err != nil {
				logger.Error(err.Error())
				break
			}
			if strings.Contains(string(body), filtercontent) {
				logger.Info("MATCH", logger.Args("URL", url))
				if outtputtype == 1 {
					write(url, rn, logger)
				}
			} else {
				logger.Warn("200", logger.Args("URL", "no match"))
			}
		case 2:
			body, err := ioutil.ReadAll(res.Body)
			if err != nil {
				logger.Error(err.Error())
				break
			}

			x, err := regexp.MatchString(filtercontent, string(body))
			if err != nil {
				logger.Error(err.Error())
			} else {
				if x {
					logger.Info("MATCH", logger.Args("URL", url))
					if outtputtype == 1 {
						write(url, rn, logger)
					}
				} else {
					logger.Warn("200", logger.Args("URL", "no match"))
				}
			}
		}
	} else if res.StatusCode == 404 {
		logger.Warn("404 NOT FOUND")
	} else if res.StatusCode == 403 {
		logger.Warn("403 FORBIDDEN")
	} else {
		logger.Error(strconv.Itoa(res.StatusCode))
	}

}

func main() {
	var filtertype = flag.Int("f", 0, "Specify the method of filtering:\n\t-'0' = none\n\t-'1' = plain text\n\t-'2' = regular expression")
	var filtercontent = flag.String("c", "", "Apply filter:")
	// var serv = flag.String("s", "0123", "Specify what services to scrape:\n\t-'0' = Rentry.co\n\t-'1' = Pasteall.org\n\t-'2' = Paste.in\n\t-'3' = Paste.ee")
	var outputtype = flag.Int("o", 0, "Specify where to output the results:\n\t-'0'=print\n\t-'1' = .txt")

	flag.Parse()

	// fmt.Printf("filter %d\n", *filtertype)
	// fmt.Printf(*filtercontent + "\n")

	logger := pterm.DefaultLogger.
		WithLevel(pterm.LogLevelTrace)

	if (*filtertype != 0) && (*filtercontent == "") {
		logger.Error("INVALID ARGUMENTS", logger.Args("reason", "Please apply a content filter or remove the filtering argument"))
	} else {

		for true {
			retrieveRaw("https://rentry.co/"+trueRand(5, "abcdefghijklmnopqrstuvwxyz0123456789")+"/raw", *filtertype, *filtercontent, *outputtype, logger)
		}
	}
}

func write(url string, filePath string, logger *pterm.Logger) {
	f, err := os.OpenFile("./"+filePath, os.O_CREATE|os.O_APPEND|os.O_WRONLY, 0644)
	if err != nil {
		logger.Error(err.Error())
	}
	writer := bufio.NewWriter(f)

	defer writer.Flush()

	writer.WriteString(url)
	writer.WriteString("\n")
}
