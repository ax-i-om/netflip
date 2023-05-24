package main

import (
	"flag"
	"fmt"
	"io/ioutil"
	"math/rand"
	"net/http"
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

func retrieveRaw(url string, filtertype int, filtercontent string, logger *pterm.Logger) {
	method := "GET"
	client := &http.Client{}
	req, err := http.NewRequest(method, url, nil)

	if err != nil {
		logger.Error("when creating request", logger.Args("error", err.Error()))
	}
	res, err := client.Do(req)
	if err != nil {
		logger.Error("when sending request", logger.Args("error", err.Error()))
	}

	defer res.Body.Close()

	if res.StatusCode == 200 {
		switch filtertype {
		case 0:
			logger.Info("MATCH", logger.Args("URL", url))
		case 1:
			body, err := ioutil.ReadAll(res.Body)
			if err != nil {
				logger.Warn("couldn't read body", logger.Args("URL", url))
				break
			}
			if strings.Contains(string(body), filtercontent) {
				logger.Info("MATCH", logger.Args("URL", url))
			} else {
				logger.Warn("NO MATCH", logger.Args("URL", url))
			}
		case 2:
			body, err := ioutil.ReadAll(res.Body)
			if err != nil {
				logger.Warn("couldn't read body", logger.Args("URL", url))
				break
			}

			x, err := regexp.MatchString(filtercontent, string(body))
			if err != nil {
				logger.Error("when checking match", logger.Args("error", err.Error()))
			} else {
				if x {
					logger.Info("MATCH", logger.Args("URL", url))
				} else {
					logger.Warn("NO MATCH", logger.Args("URL", url))
				}
			}
		}
	} else if res.StatusCode == 404 {
		logger.Error("404", logger.Args("reason", "not found"))
	} else if res.StatusCode == 403 {
		logger.Error("403", logger.Args("reason", "forbidden / rate limited"))
	} else {
		logger.Error(strconv.Itoa(res.StatusCode), logger.Args("reason", "empty"))
	}

}

func main() {
	var filtertype = flag.Int("f", 0, "Specify the method of filtering:\n\t-'0' = none\n\t-'1' = plain text\n\t-'2' = regular expression")
	var filtercontent = flag.String("c", "", "Apply filter:")
	// var serv = flag.String("s", "0123", "Specify what services to scrape:\n\t-'0' = Rentry.co\n\t-'1' = Pasteall.org\n\t-'2' = Paste.in\n\t-'3' = Paste.ee")
	// var outputtype = flag.Int("o", 0, "Specify where to output the results:\n\t-'0'=print\n\t-'1' = .txt")

	flag.Parse()

	// fmt.Printf("filter %d\n", *filtertype)
	// fmt.Printf(*filtercontent + "\n")

	if (*filtertype != 0) && (*filtercontent == "") {
		fmt.Println("Please properly apply a filter or disable filtering")
	} else {
		logger := pterm.DefaultLogger.
			WithLevel(pterm.LogLevelTrace)
		for true {
			retrieveRaw("https://rentry.co/"+trueRand(5, "abcdefghijklmnopqrstuvwxyz0123456789")+"/raw", *filtertype, *filtercontent, logger)
		}
	}
}
