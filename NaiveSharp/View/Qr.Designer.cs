namespace NaiveSharp.View
{
    partial class Qr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qr));
            this.qrcQrImg = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSharelink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // qrcQrImg
            // 
            this.qrcQrImg.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrcQrImg.Location = new System.Drawing.Point(11, 14);
            this.qrcQrImg.Name = "qrcQrImg";
            this.qrcQrImg.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrcQrImg.Size = new System.Drawing.Size(280, 280);
            this.qrcQrImg.TabIndex = 0;
            this.qrcQrImg.Text = "qrCodeGraphicControl1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(186, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(79, 42);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSharelink
            // 
            this.txtSharelink.Location = new System.Drawing.Point(38, 300);
            this.txtSharelink.Name = "txtSharelink";
            this.txtSharelink.ReadOnly = true;
            this.txtSharelink.Size = new System.Drawing.Size(227, 25);
            this.txtSharelink.TabIndex = 2;
            this.txtSharelink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSharelink_MouseUp);
            // 
            // Qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 395);
            this.Controls.Add(this.txtSharelink);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.qrcQrImg);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Qr";
            this.Text = "QR Code";
            this.Load += new System.EventHandler(this.Qr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrcQrImg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSharelink;
    }
}