namespace NaiveSharp.View
{
    partial class MainWindow
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rdoGlobal = new System.Windows.Forms.RadioButton();
            this.rdoGfwlist = new System.Windows.Forms.RadioButton();
            this.rdoGeoIP = new System.Windows.Forms.RadioButton();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.tblProxyMode = new System.Windows.Forms.TableLayoutPanel();
            this.lblProxyMode = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Button();
            this.lblStop = new System.Windows.Forms.Button();
            this.tblScheme = new System.Windows.Forms.TableLayoutPanel();
            this.lblScheme = new System.Windows.Forms.Label();
            this.rdoHttps = new System.Windows.Forms.RadioButton();
            this.rdoQuic = new System.Windows.Forms.RadioButton();
            this.chkPadding = new System.Windows.Forms.CheckBox();
            this.tblOperate = new System.Windows.Forms.TableLayoutPanel();
            this.lblSave = new System.Windows.Forms.Button();
            this.icnNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGFWList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeoIP = new System.Windows.Forms.ToolStripMenuItem();
            this.smiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.smiCopyShareLink = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLoadShareLink = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.smiRun = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.smiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblInfo.SuspendLayout();
            this.tblProxyMode.SuspendLayout();
            this.tblScheme.SuspendLayout();
            this.tblOperate.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(77, 35);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(292, 23);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(77, 4);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(292, 23);
            this.txtHost.TabIndex = 4;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(77, 66);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(292, 23);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // rdoGlobal
            // 
            this.rdoGlobal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoGlobal.AutoSize = true;
            this.rdoGlobal.Checked = true;
            this.rdoGlobal.Location = new System.Drawing.Point(77, 4);
            this.rdoGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGlobal.Name = "rdoGlobal";
            this.rdoGlobal.Size = new System.Drawing.Size(59, 18);
            this.rdoGlobal.TabIndex = 7;
            this.rdoGlobal.TabStop = true;
            this.rdoGlobal.Text = "Global";
            this.rdoGlobal.UseVisualStyleBackColor = true;
            this.rdoGlobal.CheckedChanged += new System.EventHandler(this.rdoGlobal_CheckedChanged);
            // 
            // rdoGfwlist
            // 
            this.rdoGfwlist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoGfwlist.AutoSize = true;
            this.rdoGfwlist.Location = new System.Drawing.Point(188, 4);
            this.rdoGfwlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGfwlist.Name = "rdoGfwlist";
            this.rdoGfwlist.Size = new System.Drawing.Size(68, 18);
            this.rdoGfwlist.TabIndex = 8;
            this.rdoGfwlist.TabStop = true;
            this.rdoGfwlist.Text = "GFWList";
            this.rdoGfwlist.UseVisualStyleBackColor = true;
            this.rdoGfwlist.CheckedChanged += new System.EventHandler(this.rdoGfwlist_CheckedChanged);
            // 
            // rdoGeoIP
            // 
            this.rdoGeoIP.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoGeoIP.AutoSize = true;
            this.rdoGeoIP.Location = new System.Drawing.Point(313, 4);
            this.rdoGeoIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGeoIP.Name = "rdoGeoIP";
            this.rdoGeoIP.Size = new System.Drawing.Size(56, 18);
            this.rdoGeoIP.TabIndex = 9;
            this.rdoGeoIP.TabStop = true;
            this.rdoGeoIP.Text = "GeoIP";
            this.rdoGeoIP.UseVisualStyleBackColor = true;
            this.rdoGeoIP.CheckedChanged += new System.EventHandler(this.rdoGeoIP_CheckedChanged);
            // 
            // tblInfo
            // 
            this.tblInfo.ColumnCount = 2;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblInfo.Controls.Add(this.txtHost, 1, 0);
            this.tblInfo.Controls.Add(this.txtPassword, 1, 2);
            this.tblInfo.Controls.Add(this.txtUsername, 1, 1);
            this.tblInfo.Controls.Add(this.lblUsername, 0, 1);
            this.tblInfo.Controls.Add(this.lblPassword, 0, 2);
            this.tblInfo.Controls.Add(this.lblHost, 0, 0);
            this.tblInfo.Location = new System.Drawing.Point(12, 44);
            this.tblInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 3;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblInfo.Size = new System.Drawing.Size(372, 94);
            this.tblInfo.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(3, 8);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 15);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "Host";
            // 
            // tblProxyMode
            // 
            this.tblProxyMode.ColumnCount = 4;
            this.tblProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.tblProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblProxyMode.Controls.Add(this.lblProxyMode, 0, 0);
            this.tblProxyMode.Controls.Add(this.rdoGeoIP, 3, 0);
            this.tblProxyMode.Controls.Add(this.rdoGlobal, 1, 0);
            this.tblProxyMode.Controls.Add(this.rdoGfwlist, 2, 0);
            this.tblProxyMode.Location = new System.Drawing.Point(12, 141);
            this.tblProxyMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblProxyMode.Name = "tblProxyMode";
            this.tblProxyMode.RowCount = 1;
            this.tblProxyMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProxyMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tblProxyMode.Size = new System.Drawing.Size(372, 26);
            this.tblProxyMode.TabIndex = 8;
            // 
            // lblProxyMode
            // 
            this.lblProxyMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProxyMode.AutoSize = true;
            this.lblProxyMode.Location = new System.Drawing.Point(3, 5);
            this.lblProxyMode.Name = "lblProxyMode";
            this.lblProxyMode.Size = new System.Drawing.Size(38, 15);
            this.lblProxyMode.TabIndex = 9;
            this.lblProxyMode.Text = "Mode";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(96, 6);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(87, 29);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.Location = new System.Drawing.Point(282, 6);
            this.lblExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(87, 29);
            this.lblExit.TabIndex = 14;
            this.lblExit.Text = "Exit";
            this.lblExit.UseVisualStyleBackColor = true;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblStop
            // 
            this.lblStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStop.Location = new System.Drawing.Point(189, 6);
            this.lblStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(87, 29);
            this.lblStop.TabIndex = 13;
            this.lblStop.Text = "Stop";
            this.lblStop.UseVisualStyleBackColor = true;
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // tblScheme
            // 
            this.tblScheme.ColumnCount = 4;
            this.tblScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.004F));
            this.tblScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.66533F));
            this.tblScheme.Controls.Add(this.lblScheme, 0, 0);
            this.tblScheme.Controls.Add(this.rdoHttps, 1, 0);
            this.tblScheme.Controls.Add(this.rdoQuic, 2, 0);
            this.tblScheme.Controls.Add(this.chkPadding, 3, 0);
            this.tblScheme.Location = new System.Drawing.Point(12, 13);
            this.tblScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblScheme.Name = "tblScheme";
            this.tblScheme.RowCount = 1;
            this.tblScheme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblScheme.Size = new System.Drawing.Size(372, 27);
            this.tblScheme.TabIndex = 12;
            // 
            // lblScheme
            // 
            this.lblScheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScheme.AutoSize = true;
            this.lblScheme.Location = new System.Drawing.Point(3, 6);
            this.lblScheme.Name = "lblScheme";
            this.lblScheme.Size = new System.Drawing.Size(49, 15);
            this.lblScheme.TabIndex = 0;
            this.lblScheme.Text = "Scheme";
            // 
            // rdoHttps
            // 
            this.rdoHttps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoHttps.AutoSize = true;
            this.rdoHttps.Checked = true;
            this.rdoHttps.Location = new System.Drawing.Point(77, 4);
            this.rdoHttps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoHttps.Name = "rdoHttps";
            this.rdoHttps.Size = new System.Drawing.Size(59, 19);
            this.rdoHttps.TabIndex = 1;
            this.rdoHttps.TabStop = true;
            this.rdoHttps.Text = "HTTPS";
            this.rdoHttps.UseVisualStyleBackColor = true;
            this.rdoHttps.CheckedChanged += new System.EventHandler(this.rdoHttps_CheckedChanged);
            // 
            // rdoQuic
            // 
            this.rdoQuic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoQuic.AutoSize = true;
            this.rdoQuic.Location = new System.Drawing.Point(196, 4);
            this.rdoQuic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoQuic.Name = "rdoQuic";
            this.rdoQuic.Size = new System.Drawing.Size(53, 19);
            this.rdoQuic.TabIndex = 2;
            this.rdoQuic.TabStop = true;
            this.rdoQuic.Text = "QUIC";
            this.rdoQuic.UseVisualStyleBackColor = true;
            // 
            // chkPadding
            // 
            this.chkPadding.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkPadding.Location = new System.Drawing.Point(275, 4);
            this.chkPadding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkPadding.Name = "chkPadding";
            this.chkPadding.Size = new System.Drawing.Size(94, 19);
            this.chkPadding.TabIndex = 3;
            this.chkPadding.Text = "Padding";
            this.chkPadding.UseVisualStyleBackColor = true;
            this.chkPadding.CheckedChanged += new System.EventHandler(this.chkPadding_CheckedChanged);
            // 
            // tblOperate
            // 
            this.tblOperate.ColumnCount = 4;
            this.tblOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOperate.Controls.Add(this.lblSave, 0, 0);
            this.tblOperate.Controls.Add(this.btnRun, 1, 0);
            this.tblOperate.Controls.Add(this.lblExit, 3, 0);
            this.tblOperate.Controls.Add(this.lblStop, 2, 0);
            this.tblOperate.Location = new System.Drawing.Point(12, 171);
            this.tblOperate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblOperate.Name = "tblOperate";
            this.tblOperate.RowCount = 1;
            this.tblOperate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblOperate.Size = new System.Drawing.Size(372, 42);
            this.tblOperate.TabIndex = 13;
            // 
            // lblSave
            // 
            this.lblSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave.Location = new System.Drawing.Point(3, 6);
            this.lblSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(87, 29);
            this.lblSave.TabIndex = 11;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // icnNotify
            // 
            this.icnNotify.ContextMenuStrip = this.cmsNotify;
            this.icnNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("icnNotify.Icon")));
            this.icnNotify.Text = "NaiveSharp";
            this.icnNotify.Visible = true;
            this.icnNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icnNotify_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMode,
            this.smiRun,
            this.smiStop,
            this.tss1,
            this.smiCopyShareLink,
            this.smiLoadShareLink,
            this.tss2,
            this.smiAbout,
            this.smiExit});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.ShowImageMargin = false;
            this.cmsNotify.Size = new System.Drawing.Size(195, 170);
            this.cmsNotify.Text = "cmsNotify";
            this.cmsNotify.Opening += new System.ComponentModel.CancelEventHandler(this.cmsNotify_Opening);
            // 
            // tsmMode
            // 
            this.tsmMode.Checked = true;
            this.tsmMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGlobal,
            this.tsmGFWList,
            this.tsmGeoIP});
            this.tsmMode.Name = "tsmMode";
            this.tsmMode.Size = new System.Drawing.Size(194, 22);
            this.tsmMode.Text = "Mode";
            // 
            // tsmGlobal
            // 
            this.tsmGlobal.Name = "tsmGlobal";
            this.tsmGlobal.Size = new System.Drawing.Size(180, 22);
            this.tsmGlobal.Text = "Global";
            this.tsmGlobal.Click += new System.EventHandler(this.tsmGlobal_Click);
            // 
            // tsmGFWList
            // 
            this.tsmGFWList.Name = "tsmGFWList";
            this.tsmGFWList.Size = new System.Drawing.Size(180, 22);
            this.tsmGFWList.Text = "GFWList";
            this.tsmGFWList.Click += new System.EventHandler(this.tsmGFWList_Click);
            // 
            // tsmGeoIP
            // 
            this.tsmGeoIP.Name = "tsmGeoIP";
            this.tsmGeoIP.Size = new System.Drawing.Size(180, 22);
            this.tsmGeoIP.Text = "GeoIP";
            this.tsmGeoIP.Click += new System.EventHandler(this.tsmGeoIP_Click);
            // 
            // smiAbout
            // 
            this.smiAbout.Name = "smiAbout";
            this.smiAbout.Size = new System.Drawing.Size(194, 22);
            this.smiAbout.Text = "About...";
            this.smiAbout.Click += new System.EventHandler(this.smiAbout_Click);
            // 
            // smiCopyShareLink
            // 
            this.smiCopyShareLink.Name = "smiCopyShareLink";
            this.smiCopyShareLink.Size = new System.Drawing.Size(194, 22);
            this.smiCopyShareLink.Text = "Copy your config";
            this.smiCopyShareLink.Click += new System.EventHandler(this.smiCopyShareLink_Click);
            // 
            // smiLoadShareLink
            // 
            this.smiLoadShareLink.Name = "smiLoadShareLink";
            this.smiLoadShareLink.Size = new System.Drawing.Size(194, 22);
            this.smiLoadShareLink.Text = "Load config from clipboard";
            this.smiLoadShareLink.Click += new System.EventHandler(this.smiLoadShareLink_Click);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(191, 6);
            // 
            // smiRun
            // 
            this.smiRun.Name = "smiRun";
            this.smiRun.Size = new System.Drawing.Size(194, 22);
            this.smiRun.Text = "Run";
            this.smiRun.Click += new System.EventHandler(this.smiRun_Click);
            // 
            // smiStop
            // 
            this.smiStop.Name = "smiStop";
            this.smiStop.Size = new System.Drawing.Size(194, 22);
            this.smiStop.Text = "Stop";
            this.smiStop.Click += new System.EventHandler(this.smiStop_Click);
            // 
            // smiExit
            // 
            this.smiExit.Name = "smiExit";
            this.smiExit.Size = new System.Drawing.Size(194, 22);
            this.smiExit.Text = "Exit";
            this.smiExit.Click += new System.EventHandler(this.smiExit_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(191, 6);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(393, 221);
            this.Controls.Add(this.tblOperate);
            this.Controls.Add(this.tblScheme);
            this.Controls.Add(this.tblProxyMode);
            this.Controls.Add(this.tblInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Naive # 0.5 Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.tblInfo.ResumeLayout(false);
            this.tblInfo.PerformLayout();
            this.tblProxyMode.ResumeLayout(false);
            this.tblProxyMode.PerformLayout();
            this.tblScheme.ResumeLayout(false);
            this.tblScheme.PerformLayout();
            this.tblOperate.ResumeLayout(false);
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnRun;
        public System.Windows.Forms.CheckBox chkPadding;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblProxyMode;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Label lblScheme;
        private System.Windows.Forms.Button lblStop;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.RadioButton rdoGeoIP;
        private System.Windows.Forms.RadioButton rdoGfwlist;
        private System.Windows.Forms.RadioButton rdoGlobal;
        public System.Windows.Forms.RadioButton rdoHttps;
        public System.Windows.Forms.RadioButton rdoQuic;
        private System.Windows.Forms.TableLayoutPanel tblInfo;
        private System.Windows.Forms.TableLayoutPanel tblOperate;
        private System.Windows.Forms.TableLayoutPanel tblProxyMode;
        private System.Windows.Forms.TableLayoutPanel tblScheme;
        public System.Windows.Forms.TextBox txtHost;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;

        #endregion

        private System.Windows.Forms.NotifyIcon icnNotify;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem smiRun;
        private System.Windows.Forms.ToolStripMenuItem smiStop;
        private System.Windows.Forms.ToolStripMenuItem smiExit;
        private System.Windows.Forms.ToolStripMenuItem smiAbout;
        private System.Windows.Forms.ToolStripMenuItem smiCopyShareLink;
        private System.Windows.Forms.ToolStripMenuItem smiLoadShareLink;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripMenuItem tsmMode;
        private System.Windows.Forms.ToolStripMenuItem tsmGlobal;
        private System.Windows.Forms.ToolStripMenuItem tsmGFWList;
        private System.Windows.Forms.ToolStripMenuItem tsmGeoIP;
        private System.Windows.Forms.ToolStripSeparator tss1;
    }
}

