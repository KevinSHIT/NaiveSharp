namespace NaiveSharp
{
    partial class MainWindows
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdoGlobal = new System.Windows.Forms.RadioButton();
            this.rdoGfwlist = new System.Windows.Forms.RadioButton();
            this.rdoGeoIP = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProxyMode = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Button();
            this.lblStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScheme = new System.Windows.Forms.Label();
            this.rdoHttps = new System.Windows.Forms.RadioButton();
            this.rdoQuic = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(88, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(338, 21);
            this.txtUsername.TabIndex = 0;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(88, 72);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(338, 21);
            this.txtHost.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(88, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // rdoGlobal
            // 
            this.rdoGlobal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoGlobal.AutoSize = true;
            this.rdoGlobal.Checked = true;
            this.rdoGlobal.Location = new System.Drawing.Point(88, 7);
            this.rdoGlobal.Name = "rdoGlobal";
            this.rdoGlobal.Size = new System.Drawing.Size(59, 16);
            this.rdoGlobal.TabIndex = 4;
            this.rdoGlobal.TabStop = true;
            this.rdoGlobal.Text = "Global";
            this.rdoGlobal.UseVisualStyleBackColor = true;
            this.rdoGlobal.CheckedChanged += new System.EventHandler(this.rdoGlobal_CheckedChanged);
            // 
            // rdoGfwlist
            // 
            this.rdoGfwlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoGfwlist.AutoSize = true;
            this.rdoGfwlist.Location = new System.Drawing.Point(223, 7);
            this.rdoGfwlist.Name = "rdoGfwlist";
            this.rdoGfwlist.Size = new System.Drawing.Size(65, 16);
            this.rdoGfwlist.TabIndex = 5;
            this.rdoGfwlist.Text = "GFWList";
            this.rdoGfwlist.UseVisualStyleBackColor = true;
            // 
            // rdoGeoIP
            // 
            this.rdoGeoIP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoGeoIP.AutoSize = true;
            this.rdoGeoIP.Location = new System.Drawing.Point(373, 7);
            this.rdoGeoIP.Name = "rdoGeoIP";
            this.rdoGeoIP.Size = new System.Drawing.Size(53, 16);
            this.rdoGeoIP.TabIndex = 6;
            this.rdoGeoIP.Text = "GeoIP";
            this.rdoGeoIP.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHost, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 100);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 12);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 43);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 12);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(3, 77);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 12);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "Host";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tableLayoutPanel2.Controls.Add(this.lblProxyMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoGeoIP, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoGlobal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rdoGfwlist, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(429, 30);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblProxyMode
            // 
            this.lblProxyMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProxyMode.AutoSize = true;
            this.lblProxyMode.Location = new System.Drawing.Point(3, 9);
            this.lblProxyMode.Name = "lblProxyMode";
            this.lblProxyMode.Size = new System.Drawing.Size(65, 12);
            this.lblProxyMode.TabIndex = 9;
            this.lblProxyMode.Text = "Proxy Mode";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRun.Location = new System.Drawing.Point(123, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblExit.Location = new System.Drawing.Point(351, 5);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(75, 23);
            this.lblExit.TabIndex = 10;
            this.lblExit.Text = "Exit";
            this.lblExit.UseVisualStyleBackColor = true;
            // 
            // lblStop
            // 
            this.lblStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStop.Location = new System.Drawing.Point(230, 5);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(75, 23);
            this.lblStop.TabIndex = 11;
            this.lblStop.Text = "Stop";
            this.lblStop.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.lblScheme, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdoHttps, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rdoQuic, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(429, 20);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // lblScheme
            // 
            this.lblScheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScheme.AutoSize = true;
            this.lblScheme.Location = new System.Drawing.Point(3, 4);
            this.lblScheme.Name = "lblScheme";
            this.lblScheme.Size = new System.Drawing.Size(41, 12);
            this.lblScheme.TabIndex = 0;
            this.lblScheme.Text = "Scheme";
            // 
            // rdoHttps
            // 
            this.rdoHttps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoHttps.AutoSize = true;
            this.rdoHttps.Checked = true;
            this.rdoHttps.Location = new System.Drawing.Point(88, 3);
            this.rdoHttps.Name = "rdoHttps";
            this.rdoHttps.Size = new System.Drawing.Size(53, 14);
            this.rdoHttps.TabIndex = 1;
            this.rdoHttps.TabStop = true;
            this.rdoHttps.Text = "HTTPS";
            this.rdoHttps.UseVisualStyleBackColor = true;
            // 
            // rdoQuic
            // 
            this.rdoQuic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoQuic.AutoSize = true;
            this.rdoQuic.Location = new System.Drawing.Point(379, 3);
            this.rdoQuic.Name = "rdoQuic";
            this.rdoQuic.Size = new System.Drawing.Size(47, 14);
            this.rdoQuic.TabIndex = 2;
            this.rdoQuic.Text = "QUIC";
            this.rdoQuic.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.lblSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRun, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblExit, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblStop, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 180);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(429, 34);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // lblSave
            // 
            this.lblSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSave.Location = new System.Drawing.Point(3, 5);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(75, 23);
            this.lblSave.TabIndex = 14;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(460, 225);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindows";
            this.Text = "Naive# - by Kevin";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.RadioButton rdoGlobal;
        private System.Windows.Forms.RadioButton rdoGfwlist;
        private System.Windows.Forms.RadioButton rdoGeoIP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblProxyMode;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.Button lblStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblScheme;
        private System.Windows.Forms.RadioButton rdoHttps;
        private System.Windows.Forms.RadioButton rdoQuic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button lblSave;
    }
}

