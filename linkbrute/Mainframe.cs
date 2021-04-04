using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkbrute
{
    public partial class Mainframe : Form
    {
        private bool gbflag = false;
        private bool reflag = false;
        private bool paflag = false;
        private bool piflag = false;
        private bool peflag = false;

        public Mainframe()
        {
            InitializeComponent();
        }

        private void GhostbinFormButton_Click(object sender, EventArgs e)
        {
            if (gbflag)             
            {
                gbflag = false;
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    new Thread(() =>
                    {
                        gbflag = true;
                        while (gbflag)
                        {
                            try
                            {
                                var link = "https://ghostbin.co/paste/" + Classes.Utils.GenString(5, false, true, true) + "/raw";
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
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            gbflag = false;
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
        }

        private void RentryFormButton_Click(object sender, EventArgs e)
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
                                var link = "https://rentry.co/" + Classes.Utils.GenString(5, false, true, true) + "/raw";
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
                            catch { 
                            // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void Mainframe_FormClosed(object sender, FormClosedEventArgs e)
        {
            gbflag = false;
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
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
                                var link = "https://pasteall.org/" + Classes.Utils.GenString(4, true, true, false) + "/raw";
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
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void PasteInButton_Click(object sender, EventArgs e)
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
                                var link = "https://paste.in/raw/" + Classes.Utils.GenString(6, true, true, true);
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
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void PasteEeButton_Click(object sender, EventArgs e)
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
                                var link = "https://paste.ee/r/" + Classes.Utils.GenString(5, true, true, true) + "/0";
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
                            catch
                            {
                                // Ignore
                            }
                        }
                    }).Start();
                }
            }
        }

        private void StartAllButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Linkbrute", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Linkbrute", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomFormButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon", "Linkbrute", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
