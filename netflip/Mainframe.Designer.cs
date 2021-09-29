
namespace netflip
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
            this.workingLinks = new System.Windows.Forms.TextBox();
            this.previewLinkOut = new System.Windows.Forms.TextBox();
            this.previewOut = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ThreadField = new System.Windows.Forms.TextBox();
            this.KeywordField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.StopAllButton = new System.Windows.Forms.Button();
            this.PasteeButton = new System.Windows.Forms.Button();
            this.PasteinButton = new System.Windows.Forms.Button();
            this.PasteallButton = new System.Windows.Forms.Button();
            this.RentryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.panel1.Controls.Add(this.panelChildForm);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 587);
            this.panel1.TabIndex = 0;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelChildForm.Controls.Add(this.checkingOut);
            this.panelChildForm.Controls.Add(this.textBox1);
            this.panelChildForm.Controls.Add(this.workingLinks);
            this.panelChildForm.Controls.Add(this.previewLinkOut);
            this.panelChildForm.Controls.Add(this.previewOut);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChildForm.Location = new System.Drawing.Point(177, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(862, 587);
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
            this.checkingOut.Size = new System.Drawing.Size(571, 24);
            this.checkingOut.TabIndex = 12;
            this.checkingOut.Text = "Checking:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(590, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 24);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Working Links:";
            // 
            // workingLinks
            // 
            this.workingLinks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.workingLinks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workingLinks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.workingLinks.ForeColor = System.Drawing.Color.White;
            this.workingLinks.Location = new System.Drawing.Point(590, 39);
            this.workingLinks.Multiline = true;
            this.workingLinks.Name = "workingLinks";
            this.workingLinks.ReadOnly = true;
            this.workingLinks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.workingLinks.Size = new System.Drawing.Size(260, 536);
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
            this.previewLinkOut.Size = new System.Drawing.Size(571, 24);
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
            this.previewOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.previewOut.Size = new System.Drawing.Size(571, 506);
            this.previewOut.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.HelpButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ThreadField);
            this.panel3.Controls.Add(this.KeywordField);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ResetButton);
            this.panel3.Controls.Add(this.ExportButton);
            this.panel3.Controls.Add(this.StopAllButton);
            this.panel3.Controls.Add(this.PasteeButton);
            this.panel3.Controls.Add(this.PasteinButton);
            this.panel3.Controls.Add(this.PasteallButton);
            this.panel3.Controls.Add(this.RentryButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 587);
            this.panel3.TabIndex = 1;
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.HelpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.ForeColor = System.Drawing.Color.White;
            this.HelpButton.Location = new System.Drawing.Point(12, 9);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(150, 35);
            this.HelpButton.TabIndex = 28;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Threads to Launch:";
            // 
            // ThreadField
            // 
            this.ThreadField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ThreadField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ThreadField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadField.ForeColor = System.Drawing.Color.White;
            this.ThreadField.Location = new System.Drawing.Point(12, 67);
            this.ThreadField.Multiline = true;
            this.ThreadField.Name = "ThreadField";
            this.ThreadField.ShortcutsEnabled = false;
            this.ThreadField.Size = new System.Drawing.Size(150, 21);
            this.ThreadField.TabIndex = 26;
            this.ThreadField.Text = "10";
            this.ThreadField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ThreadField_MouseClick);
            this.ThreadField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThreadField_KeyPress);
            // 
            // KeywordField
            // 
            this.KeywordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.KeywordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeywordField.ForeColor = System.Drawing.Color.White;
            this.KeywordField.Location = new System.Drawing.Point(12, 166);
            this.KeywordField.Multiline = true;
            this.KeywordField.Name = "KeywordField";
            this.KeywordField.Size = new System.Drawing.Size(150, 90);
            this.KeywordField.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Filter Type:";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(12, 458);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 35);
            this.ResetButton.TabIndex = 22;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.ExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(12, 499);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(150, 35);
            this.ExportButton.TabIndex = 14;
            this.ExportButton.Text = "Export Pastes";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click_1);
            // 
            // StopAllButton
            // 
            this.StopAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.StopAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.StopAllButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.StopAllButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.StopAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopAllButton.ForeColor = System.Drawing.Color.White;
            this.StopAllButton.Location = new System.Drawing.Point(12, 540);
            this.StopAllButton.Name = "StopAllButton";
            this.StopAllButton.Size = new System.Drawing.Size(150, 35);
            this.StopAllButton.TabIndex = 13;
            this.StopAllButton.Text = "Stop All Threads";
            this.StopAllButton.UseVisualStyleBackColor = false;
            this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // PasteeButton
            // 
            this.PasteeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.PasteeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.PasteeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteeButton.ForeColor = System.Drawing.Color.White;
            this.PasteeButton.Location = new System.Drawing.Point(12, 385);
            this.PasteeButton.Name = "PasteeButton";
            this.PasteeButton.Size = new System.Drawing.Size(150, 35);
            this.PasteeButton.TabIndex = 12;
            this.PasteeButton.Text = "Paste.ee";
            this.PasteeButton.UseVisualStyleBackColor = false;
            this.PasteeButton.Click += new System.EventHandler(this.PasteeButton_Click);
            // 
            // PasteinButton
            // 
            this.PasteinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.PasteinButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.PasteinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteinButton.ForeColor = System.Drawing.Color.White;
            this.PasteinButton.Location = new System.Drawing.Point(12, 344);
            this.PasteinButton.Name = "PasteinButton";
            this.PasteinButton.Size = new System.Drawing.Size(150, 35);
            this.PasteinButton.TabIndex = 11;
            this.PasteinButton.Text = "Paste.in";
            this.PasteinButton.UseVisualStyleBackColor = false;
            this.PasteinButton.Click += new System.EventHandler(this.PasteinButton_Click_1);
            // 
            // PasteallButton
            // 
            this.PasteallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.PasteallButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.PasteallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.PasteallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteallButton.ForeColor = System.Drawing.Color.White;
            this.PasteallButton.Location = new System.Drawing.Point(12, 303);
            this.PasteallButton.Name = "PasteallButton";
            this.PasteallButton.Size = new System.Drawing.Size(150, 35);
            this.PasteallButton.TabIndex = 10;
            this.PasteallButton.Text = "Pasteall.org";
            this.PasteallButton.UseVisualStyleBackColor = false;
            this.PasteallButton.Click += new System.EventHandler(this.PasteallButton_Click);
            // 
            // RentryButton
            // 
            this.RentryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.RentryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.RentryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(196)))), ((int)(((byte)(107)))));
            this.RentryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(232)))), ((int)(((byte)(129)))));
            this.RentryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RentryButton.ForeColor = System.Drawing.Color.White;
            this.RentryButton.Location = new System.Drawing.Point(12, 262);
            this.RentryButton.Name = "RentryButton";
            this.RentryButton.Size = new System.Drawing.Size(150, 35);
            this.RentryButton.TabIndex = 9;
            this.RentryButton.Text = "Rentry.co";
            this.RentryButton.UseVisualStyleBackColor = false;
            this.RentryButton.Click += new System.EventHandler(this.RentryButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 2);
            this.label1.TabIndex = 29;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(13, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 21);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Plain Text";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(12, 139);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 21);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.Text = "RegEx";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Mainframe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1039, 587);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainframe";
            this.Text = "Netflip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainframe_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.TextBox workingLinks;
        private System.Windows.Forms.TextBox previewLinkOut;
        private System.Windows.Forms.TextBox previewOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox checkingOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button StopAllButton;
        private System.Windows.Forms.Button PasteeButton;
        private System.Windows.Forms.Button PasteinButton;
        private System.Windows.Forms.Button PasteallButton;
        private System.Windows.Forms.Button RentryButton;
        private System.Windows.Forms.TextBox KeywordField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ThreadField;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

