namespace NaiveSharp.View
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.picNavBackground = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContext = new System.Windows.Forms.Label();
            this.lstCredit = new System.Windows.Forms.ListBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.llbLicense = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picNavBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picNavBackground
            // 
            this.picNavBackground.BackColor = System.Drawing.SystemColors.Window;
            this.picNavBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.picNavBackground.Location = new System.Drawing.Point(0, 0);
            this.picNavBackground.Margin = new System.Windows.Forms.Padding(4);
            this.picNavBackground.Name = "picNavBackground";
            this.picNavBackground.Size = new System.Drawing.Size(463, 72);
            this.picNavBackground.TabIndex = 0;
            this.picNavBackground.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(79)))));
            this.lblName.Location = new System.Drawing.Point(16, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 37);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Naive#";
            // 
            // lblContext
            // 
            this.lblContext.AutoSize = true;
            this.lblContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContext.Location = new System.Drawing.Point(19, 88);
            this.lblContext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContext.Name = "lblContext";
            this.lblContext.Size = new System.Drawing.Size(141, 80);
            this.lblContext.TabIndex = 2;
            this.lblContext.Text = "NaiveSharp\r\nVersion 0.6.6-prev\r\n© 2020 KevinZonda\r\nGNU GPL  v3.0";
            // 
            // lstCredit
            // 
            this.lstCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCredit.FormattingEnabled = true;
            this.lstCredit.ItemHeight = 20;
            this.lstCredit.Items.AddRange(new object[] {
            "klzgrad/naiveproxy - BSD 3-Clause",
            "trojan-gfw/igniter - GPLv3",
            "Dreamacro/clash - GPLv3",
            "privoxy.org/privoxy - GPLv2",
            "QrCode.NET - MIT"});
            this.lstCredit.Location = new System.Drawing.Point(23, 204);
            this.lstCredit.Margin = new System.Windows.Forms.Padding(4);
            this.lstCredit.Name = "lstCredit";
            this.lstCredit.Size = new System.Drawing.Size(416, 124);
            this.lstCredit.TabIndex = 3;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(19, 180);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(49, 20);
            this.lblCredit.TabIndex = 4;
            this.lblCredit.Text = "Credit";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(340, 337);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // llbLicense
            // 
            this.llbLicense.AccessibleDescription = "License of NaiveSharp";
            this.llbLicense.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.AutoSize = true;
            this.llbLicense.BackColor = System.Drawing.SystemColors.Window;
            this.llbLicense.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLicense.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llbLicense.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.Location = new System.Drawing.Point(353, 24);
            this.llbLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbLicense.Name = "llbLicense";
            this.llbLicense.Size = new System.Drawing.Size(64, 20);
            this.llbLicense.TabIndex = 6;
            this.llbLicense.TabStop = true;
            this.llbLicense.Text = "LICENSE";
            this.llbLicense.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLicense_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 377);
            this.Controls.Add(this.llbLicense);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lstCredit);
            this.Controls.Add(this.lblContext);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picNavBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Text = "About Naive#";
            ((System.ComponentModel.ISupportInitialize)(this.picNavBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNavBackground;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContext;
        private System.Windows.Forms.ListBox lstCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel llbLicense;
    }
}