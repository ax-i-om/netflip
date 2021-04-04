
namespace linkbrute
{
    partial class Mainframe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainframe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.checkingOut = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.StopAllButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.StartAllButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.workingLinks = new System.Windows.Forms.TextBox();
            this.previewLinkOut = new System.Windows.Forms.TextBox();
            this.previewOut = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PasteInButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.CustomFormButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.PasteEeButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.PasteallButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.RentryButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneCirclePictureBox1 = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.GhostbinButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 447);
            this.panel1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelChildForm.Controls.Add(this.checkingOut);
            this.panelChildForm.Controls.Add(this.textBox1);
            this.panelChildForm.Controls.Add(this.ExportButton);
            this.panelChildForm.Controls.Add(this.StopAllButton);
            this.panelChildForm.Controls.Add(this.StartAllButton);
            this.panelChildForm.Controls.Add(this.workingLinks);
            this.panelChildForm.Controls.Add(this.previewLinkOut);
            this.panelChildForm.Controls.Add(this.previewOut);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChildForm.Location = new System.Drawing.Point(178, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(622, 447);
            this.panelChildForm.TabIndex = 1;
            // 
            // checkingOut
            // 
            this.checkingOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.checkingOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkingOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkingOut.ForeColor = System.Drawing.Color.White;
            this.checkingOut.Location = new System.Drawing.Point(13, 9);
            this.checkingOut.Multiline = true;
            this.checkingOut.Name = "checkingOut";
            this.checkingOut.ReadOnly = true;
            this.checkingOut.Size = new System.Drawing.Size(381, 24);
            this.checkingOut.TabIndex = 12;
            this.checkingOut.Text = "Checking:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(400, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 24);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Working Links:";
            // 
            // ExportButton
            // 
            this.ExportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.ExportButton.BorderThickness = 1;
            this.ExportButton.CheckedState.Parent = this.ExportButton;
            this.ExportButton.CustomImages.Parent = this.ExportButton;
            this.ExportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.HoveredState.Parent = this.ExportButton;
            this.ExportButton.Location = new System.Drawing.Point(400, 119);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.ShadowDecoration.Parent = this.ExportButton;
            this.ExportButton.Size = new System.Drawing.Size(210, 49);
            this.ExportButton.TabIndex = 10;
            this.ExportButton.Text = "Export";
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // StopAllButton
            // 
            this.StopAllButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.StopAllButton.BorderThickness = 1;
            this.StopAllButton.CheckedState.Parent = this.StopAllButton;
            this.StopAllButton.CustomImages.Parent = this.StopAllButton;
            this.StopAllButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.StopAllButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.StopAllButton.ForeColor = System.Drawing.Color.White;
            this.StopAllButton.HoveredState.Parent = this.StopAllButton;
            this.StopAllButton.Location = new System.Drawing.Point(400, 64);
            this.StopAllButton.Name = "StopAllButton";
            this.StopAllButton.ShadowDecoration.Parent = this.StopAllButton;
            this.StopAllButton.Size = new System.Drawing.Size(210, 49);
            this.StopAllButton.TabIndex = 9;
            this.StopAllButton.Text = "Stop All";
            this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // StartAllButton
            // 
            this.StartAllButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.StartAllButton.BorderThickness = 1;
            this.StartAllButton.CheckedState.Parent = this.StartAllButton;
            this.StartAllButton.CustomImages.Parent = this.StartAllButton;
            this.StartAllButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.StartAllButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.StartAllButton.ForeColor = System.Drawing.Color.White;
            this.StartAllButton.HoveredState.Parent = this.StartAllButton;
            this.StartAllButton.Location = new System.Drawing.Point(400, 9);
            this.StartAllButton.Name = "StartAllButton";
            this.StartAllButton.ShadowDecoration.Parent = this.StartAllButton;
            this.StartAllButton.Size = new System.Drawing.Size(210, 49);
            this.StartAllButton.TabIndex = 8;
            this.StartAllButton.Text = "Start All";
            this.StartAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // workingLinks
            // 
            this.workingLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.workingLinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workingLinks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.workingLinks.ForeColor = System.Drawing.Color.White;
            this.workingLinks.Location = new System.Drawing.Point(400, 204);
            this.workingLinks.Multiline = true;
            this.workingLinks.Name = "workingLinks";
            this.workingLinks.ReadOnly = true;
            this.workingLinks.Size = new System.Drawing.Size(210, 231);
            this.workingLinks.TabIndex = 2;
            // 
            // previewLinkOut
            // 
            this.previewLinkOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.previewLinkOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewLinkOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previewLinkOut.ForeColor = System.Drawing.Color.White;
            this.previewLinkOut.Location = new System.Drawing.Point(13, 39);
            this.previewLinkOut.Multiline = true;
            this.previewLinkOut.Name = "previewLinkOut";
            this.previewLinkOut.ReadOnly = true;
            this.previewLinkOut.Size = new System.Drawing.Size(381, 24);
            this.previewLinkOut.TabIndex = 1;
            this.previewLinkOut.Text = "Previewing: ";
            // 
            // previewOut
            // 
            this.previewOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.previewOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previewOut.ForeColor = System.Drawing.Color.White;
            this.previewOut.Location = new System.Drawing.Point(13, 69);
            this.previewOut.Multiline = true;
            this.previewOut.Name = "previewOut";
            this.previewOut.ReadOnly = true;
            this.previewOut.Size = new System.Drawing.Size(381, 366);
            this.previewOut.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.PasteInButton);
            this.panel3.Controls.Add(this.CustomFormButton);
            this.panel3.Controls.Add(this.PasteEeButton);
            this.panel3.Controls.Add(this.PasteallButton);
            this.panel3.Controls.Add(this.RentryButton);
            this.panel3.Controls.Add(this.siticoneCirclePictureBox1);
            this.panel3.Controls.Add(this.GhostbinButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 447);
            this.panel3.TabIndex = 1;
            // 
            // PasteInButton
            // 
            this.PasteInButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.PasteInButton.BorderThickness = 1;
            this.PasteInButton.CheckedState.Parent = this.PasteInButton;
            this.PasteInButton.CustomImages.Parent = this.PasteInButton;
            this.PasteInButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.PasteInButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasteInButton.ForeColor = System.Drawing.Color.White;
            this.PasteInButton.HoveredState.Parent = this.PasteInButton;
            this.PasteInButton.Location = new System.Drawing.Point(12, 286);
            this.PasteInButton.Name = "PasteInButton";
            this.PasteInButton.ShadowDecoration.Parent = this.PasteInButton;
            this.PasteInButton.Size = new System.Drawing.Size(149, 29);
            this.PasteInButton.TabIndex = 8;
            this.PasteInButton.Text = "Paste.in";
            this.PasteInButton.Click += new System.EventHandler(this.PasteInButton_Click);
            // 
            // CustomFormButton
            // 
            this.CustomFormButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.CustomFormButton.BorderThickness = 1;
            this.CustomFormButton.CheckedState.Parent = this.CustomFormButton;
            this.CustomFormButton.CustomImages.Parent = this.CustomFormButton;
            this.CustomFormButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.CustomFormButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomFormButton.ForeColor = System.Drawing.Color.White;
            this.CustomFormButton.HoveredState.Parent = this.CustomFormButton;
            this.CustomFormButton.Location = new System.Drawing.Point(12, 356);
            this.CustomFormButton.Name = "CustomFormButton";
            this.CustomFormButton.ShadowDecoration.Parent = this.CustomFormButton;
            this.CustomFormButton.Size = new System.Drawing.Size(149, 29);
            this.CustomFormButton.TabIndex = 7;
            this.CustomFormButton.Text = "Custom";
            this.CustomFormButton.Click += new System.EventHandler(this.CustomFormButton_Click);
            // 
            // PasteEeButton
            // 
            this.PasteEeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.PasteEeButton.BorderThickness = 1;
            this.PasteEeButton.CheckedState.Parent = this.PasteEeButton;
            this.PasteEeButton.CustomImages.Parent = this.PasteEeButton;
            this.PasteEeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.PasteEeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasteEeButton.ForeColor = System.Drawing.Color.White;
            this.PasteEeButton.HoveredState.Parent = this.PasteEeButton;
            this.PasteEeButton.Location = new System.Drawing.Point(12, 321);
            this.PasteEeButton.Name = "PasteEeButton";
            this.PasteEeButton.ShadowDecoration.Parent = this.PasteEeButton;
            this.PasteEeButton.Size = new System.Drawing.Size(149, 29);
            this.PasteEeButton.TabIndex = 5;
            this.PasteEeButton.Text = "Paste.ee";
            this.PasteEeButton.Click += new System.EventHandler(this.PasteEeButton_Click);
            // 
            // PasteallButton
            // 
            this.PasteallButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.PasteallButton.BorderThickness = 1;
            this.PasteallButton.CheckedState.Parent = this.PasteallButton;
            this.PasteallButton.CustomImages.Parent = this.PasteallButton;
            this.PasteallButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.PasteallButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasteallButton.ForeColor = System.Drawing.Color.White;
            this.PasteallButton.HoveredState.Parent = this.PasteallButton;
            this.PasteallButton.Location = new System.Drawing.Point(12, 251);
            this.PasteallButton.Name = "PasteallButton";
            this.PasteallButton.ShadowDecoration.Parent = this.PasteallButton;
            this.PasteallButton.Size = new System.Drawing.Size(149, 29);
            this.PasteallButton.TabIndex = 4;
            this.PasteallButton.Text = "Pasteall.org";
            this.PasteallButton.Click += new System.EventHandler(this.PasteallButton_Click);
            // 
            // RentryButton
            // 
            this.RentryButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.RentryButton.BorderThickness = 1;
            this.RentryButton.CheckedState.Parent = this.RentryButton;
            this.RentryButton.CustomImages.Parent = this.RentryButton;
            this.RentryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.RentryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RentryButton.ForeColor = System.Drawing.Color.White;
            this.RentryButton.HoveredState.Parent = this.RentryButton;
            this.RentryButton.Location = new System.Drawing.Point(12, 216);
            this.RentryButton.Name = "RentryButton";
            this.RentryButton.ShadowDecoration.Parent = this.RentryButton;
            this.RentryButton.Size = new System.Drawing.Size(149, 29);
            this.RentryButton.TabIndex = 2;
            this.RentryButton.Text = "Rentry.co";
            this.RentryButton.Click += new System.EventHandler(this.RentryFormButton_Click);
            // 
            // siticoneCirclePictureBox1
            // 
            this.siticoneCirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneCirclePictureBox1.Image = global::linkbrute.Properties.Resources.brute;
            this.siticoneCirclePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
            this.siticoneCirclePictureBox1.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
            this.siticoneCirclePictureBox1.Size = new System.Drawing.Size(175, 175);
            this.siticoneCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticoneCirclePictureBox1.TabIndex = 1;
            this.siticoneCirclePictureBox1.TabStop = false;
            // 
            // GhostbinButton
            // 
            this.GhostbinButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.GhostbinButton.BorderThickness = 1;
            this.GhostbinButton.CheckedState.Parent = this.GhostbinButton;
            this.GhostbinButton.CustomImages.Parent = this.GhostbinButton;
            this.GhostbinButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.GhostbinButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GhostbinButton.ForeColor = System.Drawing.Color.White;
            this.GhostbinButton.HoveredState.Parent = this.GhostbinButton;
            this.GhostbinButton.Location = new System.Drawing.Point(12, 181);
            this.GhostbinButton.Name = "GhostbinButton";
            this.GhostbinButton.ShadowDecoration.Parent = this.GhostbinButton;
            this.GhostbinButton.Size = new System.Drawing.Size(149, 29);
            this.GhostbinButton.TabIndex = 0;
            this.GhostbinButton.Text = "Ghostbin.co";
            this.GhostbinButton.Click += new System.EventHandler(this.GhostbinFormButton_Click);
            // 
            // Mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainframe";
            this.Text = "LinkBrute";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainframe_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticoneCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel3;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton GhostbinButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton CustomFormButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton PasteEeButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton PasteallButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton RentryButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton ExportButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton StopAllButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton StartAllButton;
        private System.Windows.Forms.TextBox workingLinks;
        private System.Windows.Forms.TextBox previewLinkOut;
        private System.Windows.Forms.TextBox previewOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox checkingOut;
        private Siticone.UI.WinForms.SiticoneRoundedButton PasteInButton;
    }
}

