using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netflip
{
    public partial class Mainframe : Form
    {
        private bool reflag = false;
        private bool paflag = false;
        private bool piflag = false;
        private bool peflag = false;

        public static SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            RestoreDirectory = true,
            DefaultExt = ".txt",
            Title = "Netflip | Save file",
            Filter = "Text file|*.txt|All files (*.*)|*.*",
            FilterIndex = 1,
            CreatePrompt = true
        };

        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        public static string GenString(int length, bool upper, bool lower, bool digit)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            string[] chars = null;
            string res = "";
            if (upper && !lower && !digit)
            {
                chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            }
            else if (lower && !upper && !digit)
            {
                chars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            }
            else if (digit && !upper && !lower)
            {
                chars = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            }
            else if (upper && lower && !digit)
            {
                chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            }
            else if (upper && digit && !lower)
            {
                chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            }
            else if (lower && digit && !upper)
            {
                chars = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            }
            else if (upper && lower && digit)
            {
                chars = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            }
            for (int i = 0; i < length; i++)
            {
                rand = new Random(Guid.NewGuid().GetHashCode());
                res += chars.GetValue(rand.Next(0, chars.Length));
            }
            return res;
        }

        public Mainframe()
        {
            InitializeComponent();
        }

        private void Mainframe_FormClosed(object sender, FormClosedEventArgs e)
        {
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
        }

        private void ExportButton_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, workingLinks.Text);
            }
        }

        private void PasteeButton_Click(object sender, EventArgs e)
        {
            if (peflag)
            {
                peflag = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(() =>
                    {
                        peflag = true;
                        while (peflag)
                        {
                            try
                            {
                                var link = "https://paste.ee/r/" + GenString(5, true, true, true) + "/0";
                                var client = new RestClient(link)
                                {
                                    Timeout = -1
                                };
                                var request = new RestRequest(Method.GET);
                                IRestResponse response = client.Execute(request);
                                checkingOut.Invoke(new Action(() =>
                                {
                                    checkingOut.ResetText();
                                    checkingOut.AppendText("Checking: " + link);
                                }));
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    if ((MegaRadio.Checked && response.Content.Contains("mega.nz")) || AllRadio.Checked)
                                    {
                                        previewOut.Invoke(new Action(() =>
                                        {
                                            previewOut.ResetText();
                                            previewOut.AppendText(response.Content);
                                        }));
                                        workingLinks.Invoke(new Action(() =>
                                        {
                                            workingLinks.AppendText(link);
                                            workingLinks.AppendText(Environment.NewLine);
                                        }));
                                        previewLinkOut.Invoke(new Action(() =>
                                        {
                                            previewLinkOut.ResetText();
                                            previewLinkOut.AppendText("Previewing: " + link);
                                        }));
                                    }
                                }
                            }
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void PasteallButton_Click(object sender, EventArgs e)
        {
            if (paflag)
            {
                paflag = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(() =>
                    {
                        paflag = true;
                        while (paflag)
                        {
                            try
                            {
                                var link = "https://pasteall.org/" + GenString(4, true, true, false) + "/raw";
                                var client = new RestClient(link)
                                {
                                    Timeout = -1
                                };
                                var request = new RestRequest(Method.GET);
                                IRestResponse response = client.Execute(request);
                                checkingOut.Invoke(new Action(() =>
                                {
                                    checkingOut.ResetText();
                                    checkingOut.AppendText("Checking: " + link);
                                }));
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    if ((MegaRadio.Checked && response.Content.Contains("mega.nz")) || AllRadio.Checked)
                                    {
                                        previewOut.Invoke(new Action(() =>
                                        {
                                            previewOut.ResetText();
                                            previewOut.AppendText(response.Content);
                                        }));
                                        workingLinks.Invoke(new Action(() =>
                                        {
                                            workingLinks.AppendText(link);
                                            workingLinks.AppendText(Environment.NewLine);
                                        }));
                                        previewLinkOut.Invoke(new Action(() =>
                                        {
                                            previewLinkOut.ResetText();
                                            previewLinkOut.AppendText("Previewing: " + link);
                                        }));
                                    }
                                }
                            }
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void PasteinButton_Click_1(object sender, EventArgs e)
        {
            if (piflag)
            {
                piflag = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(() =>
                    {
                        piflag = true;
                        while (piflag)
                        {
                            try
                            {
                                var link = "https://paste.in/raw/" + GenString(6, true, true, true);
                                var client = new RestClient(link)
                                {
                                    Timeout = -1
                                };
                                var request = new RestRequest(Method.GET);
                                IRestResponse response = client.Execute(request);
                                checkingOut.Invoke(new Action(() =>
                                {
                                    checkingOut.ResetText();
                                    checkingOut.AppendText("Checking: " + link);
                                }));
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    if ((MegaRadio.Checked && response.Content.Contains("mega.nz")) || AllRadio.Checked)
                                    {
                                        previewOut.Invoke(new Action(() =>
                                        {
                                            previewOut.ResetText();
                                            previewOut.AppendText(response.Content);
                                        }));
                                        workingLinks.Invoke(new Action(() =>
                                        {
                                            workingLinks.AppendText(link);
                                            workingLinks.AppendText(Environment.NewLine);
                                        }));
                                        previewLinkOut.Invoke(new Action(() =>
                                        {
                                            previewLinkOut.ResetText();
                                            previewLinkOut.AppendText("Previewing: " + link);
                                        }));
                                    }
                                }
                            }
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void RentryButton_Click(object sender, EventArgs e)
        {
            if (reflag)
            {
                reflag = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(() =>
                    {
                        reflag = true;
                        while (reflag)
                        {
                            try
                            {
                                var link = "https://rentry.co/" + GenString(5, false, true, true) + "/raw";
                                var client = new RestClient(link)
                                {
                                    Timeout = -1
                                };
                                var request = new RestRequest(Method.GET);
                                IRestResponse response = client.Execute(request);
                                checkingOut.Invoke(new Action(() =>
                                {
                                    checkingOut.ResetText();
                                    checkingOut.AppendText("Checking: " + link);
                                }));
                                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                                {
                                    if ((MegaRadio.Checked && response.Content.Contains("mega.nz")) || AllRadio.Checked)
                                    {
                                        previewOut.Invoke(new Action(() =>
                                        {
                                            previewOut.ResetText();
                                            previewOut.AppendText(response.Content);
                                        }));
                                        workingLinks.Invoke(new Action(() =>
                                        {
                                            workingLinks.AppendText(link);
                                            workingLinks.AppendText(Environment.NewLine);
                                        }));
                                        previewLinkOut.Invoke(new Action(() =>
                                        {
                                            previewLinkOut.ResetText();
                                            previewLinkOut.AppendText("Previewing: " + link);
                                        }));
                                    }
                                }
                            }
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
            previewOut.ResetText();
            workingLinks.ResetText();
            previewLinkOut.Text = "Previewing: ";
            checkingOut.Text = "Checking: ";
            AllRadio.Checked = true;
        }
    }
}
