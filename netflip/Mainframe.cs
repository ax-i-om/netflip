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
using System.Text.RegularExpressions;
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
            try
            {
                int threads = int.Parse(ThreadField.Text);
                PasteeLaunch(threads);
                peflag = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error has occured. View the error message below: \n\n" + ee.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasteallButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threads = int.Parse(ThreadField.Text);
                PasteallLaunch(threads);
                paflag = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error has occured. View the error message below: \n\n" + ee.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void PasteinButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int threads = int.Parse(ThreadField.Text);
                PasteinLaunch(threads);
                piflag = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error has occured. View the error message below: \n\n" + ee.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RentryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int threads = int.Parse(ThreadField.Text);
                RentryLaunch(threads);
                reflag = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show("An error has occured. View the error message below: \n\n" + ee.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasteeLaunch(int threads)
        {
            if (peflag)
            {
                peflag = false;
            }
            else
            {
                for (int i = 0; i < threads; i++)
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
                                    PasteeButton.FlatAppearance.BorderColor = Color.FromArgb(1, 11, 232, 129);
                                    if (RadioText.Checked)
                                    {

                                        if ((!String.IsNullOrWhiteSpace(KeywordField.Text) && response.Content.ToLower().Contains(KeywordField.Text.ToLower())) || String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                    else if (RadioReg.Checked)
                                    {
                                        if (String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                        else
                                        {
                                            try
                                            {
                                                if (Regex.IsMatch(response.Content, @KeywordField.Text))
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
                                            catch (Exception pasteeexpr)
                                            {
                                                MessageBox.Show("An error has occured. View the error message below: \n\n" + pasteeexpr.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                peflag = false;
                                            }
                                        }

                                    }
                                }
                                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                                {
                                    PasteeButton.FlatAppearance.BorderColor = Color.Red;
                                    peflag = false;
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

        private void PasteallLaunch(int threads)
        {
            if (paflag)
            {
                paflag = false;
            }
            else
            {
                for (int i = 0; i < threads; i++)
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
                                    PasteallButton.FlatAppearance.BorderColor = Color.FromArgb(1, 11, 232, 129);
                                    if (RadioText.Checked)
                                    {

                                        if ((!String.IsNullOrWhiteSpace(KeywordField.Text) && response.Content.ToLower().Contains(KeywordField.Text.ToLower())) || String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                    else if (RadioReg.Checked)
                                    {
                                        if (String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                        else
                                        {
                                            try
                                            {
                                                if (Regex.IsMatch(response.Content, @KeywordField.Text))
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
                                            catch (Exception pasteallexpr)
                                            {
                                                MessageBox.Show("An error has occured. View the error message below: \n\n" + pasteallexpr.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                paflag = false;
                                            }
                                        }

                                    }
                                }
                                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                                {
                                    PasteallButton.FlatAppearance.BorderColor = Color.Red;
                                    paflag = false;
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
            KeywordField.ResetText();
            previewLinkOut.Text = "Previewing: ";
            checkingOut.Text = "Checking: ";
        }

        private void RentryLaunch(int threads)
        {
            if (reflag)
            {
                reflag = false;
            }
            else
            {
                for (int i = 0; i < threads; i++)
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
                                    RentryButton.FlatAppearance.BorderColor = Color.FromArgb(1, 11, 232, 129);
                                    if (RadioText.Checked)
                                    {

                                        if ((!String.IsNullOrWhiteSpace(KeywordField.Text) && response.Content.ToLower().Contains(KeywordField.Text.ToLower())) || String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                    else if (RadioReg.Checked)
                                    {
                                        if (String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                        else
                                        {
                                            try
                                            {
                                                if (Regex.IsMatch(response.Content, @KeywordField.Text))
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
                                            catch (Exception rentryexpr)
                                            {
                                                MessageBox.Show("An error has occured. View the error message below: \n\n" + rentryexpr.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                reflag = false;
                                            }
                                        }

                                    }
                                }
                                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                                {
                                    RentryButton.FlatAppearance.BorderColor = Color.Red;
                                    reflag = false;
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

        private void PasteinLaunch(int threads)
        {
            if (piflag)
            {
                piflag = false;
            }
            else
            {
                for (int i = 0; i < threads; i++)
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
                                    PasteinButton.FlatAppearance.BorderColor = Color.FromArgb(1, 11, 232, 129);
                                    if (RadioText.Checked)
                                    {

                                        if ((!String.IsNullOrWhiteSpace(KeywordField.Text) && response.Content.ToLower().Contains(KeywordField.Text.ToLower())) || String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                    else if (RadioReg.Checked)
                                    {
                                        if (String.IsNullOrWhiteSpace(KeywordField.Text))
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
                                        else
                                        {
                                            try
                                            {
                                                if (Regex.IsMatch(response.Content, @KeywordField.Text))
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
                                            catch (Exception pasteinexpr)
                                            {
                                                MessageBox.Show("An error has occured. View the error message below: \n\n" + pasteinexpr.ToString(), "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                piflag = false;
                                            }
                                        }

                                    }
                                }
                                else if (response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                                {
                                    PasteinButton.FlatAppearance.BorderColor = Color.Red;
                                    piflag = false;
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

        private void ThreadField_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Make sure all processes are stopped.\n2. Set how many threads you want to launch.\n3. Set a keyword to filter for.\n4. Select which paste sites to scrape from.", "Netflip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ThreadField_MouseClick(object sender, MouseEventArgs e)
        {
            reflag = false;
            paflag = false;
            piflag = false;
            peflag = false;
        }
    }
}
