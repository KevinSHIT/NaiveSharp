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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tlpProxyMode = new System.Windows.Forms.TableLayoutPanel();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.lblProxyMode = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tlpScheme = new System.Windows.Forms.TableLayoutPanel();
            this.rdoHttps = new System.Windows.Forms.RadioButton();
            this.btnQR = new System.Windows.Forms.Button();
            this.rdoQuic = new System.Windows.Forms.RadioButton();
            this.lblScheme = new System.Windows.Forms.Label();
            this.tlpOperate = new System.Windows.Forms.TableLayoutPanel();
            this.lblSave = new System.Windows.Forms.Button();
            this.icnNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGFWList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeoIP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNone = new System.Windows.Forms.ToolStripMenuItem();
            this.smiRun = new System.Windows.Forms.ToolStripMenuItem();
            this.smiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.smiCopyShareLink = new System.Windows.Forms.ToolStripMenuItem();
            this.smiLoadShareLink = new System.Windows.Forms.ToolStripMenuItem();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.smiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.smiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tvwNodeList = new System.Windows.Forms.TreeView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.lblAddGroup = new System.Windows.Forms.Button();
            this.tplListControl = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tplControl = new System.Windows.Forms.TableLayoutPanel();
            this.tplNodeList = new System.Windows.Forms.TableLayoutPanel();
            this.tlpWindow = new System.Windows.Forms.TableLayoutPanel();
            this.tlpProxyMode.SuspendLayout();
            this.tlpScheme.SuspendLayout();
            this.tlpOperate.SuspendLayout();
            this.cmsNotify.SuspendLayout();
            this.tplListControl.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.tplControl.SuspendLayout();
            this.tplNodeList.SuspendLayout();
            this.tlpWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(98, 116);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(377, 27);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtHost
            // 
            this.txtHost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHost.Location = new System.Drawing.Point(98, 79);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(377, 27);
            this.txtHost.TabIndex = 4;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(98, 153);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(377, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // rdoGlobal
            // 
            this.rdoGlobal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoGlobal.AutoSize = true;
            this.rdoGlobal.Checked = true;
            this.rdoGlobal.Location = new System.Drawing.Point(3, 4);
            this.rdoGlobal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGlobal.Name = "rdoGlobal";
            this.rdoGlobal.Size = new System.Drawing.Size(74, 23);
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
            this.rdoGfwlist.Location = new System.Drawing.Point(99, 4);
            this.rdoGfwlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGfwlist.Name = "rdoGfwlist";
            this.rdoGfwlist.Size = new System.Drawing.Size(83, 23);
            this.rdoGfwlist.TabIndex = 8;
            this.rdoGfwlist.TabStop = true;
            this.rdoGfwlist.Text = "GFWList";
            this.rdoGfwlist.UseVisualStyleBackColor = true;
            this.rdoGfwlist.CheckedChanged += new System.EventHandler(this.rdoGfwlist_CheckedChanged);
            // 
            // rdoGeoIP
            // 
            this.rdoGeoIP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoGeoIP.AutoSize = true;
            this.rdoGeoIP.Location = new System.Drawing.Point(200, 4);
            this.rdoGeoIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoGeoIP.Name = "rdoGeoIP";
            this.rdoGeoIP.Size = new System.Drawing.Size(69, 23);
            this.rdoGeoIP.TabIndex = 9;
            this.rdoGeoIP.TabStop = true;
            this.rdoGeoIP.Text = "GeoIP";
            this.rdoGeoIP.UseVisualStyleBackColor = true;
            this.rdoGeoIP.CheckedChanged += new System.EventHandler(this.rdoGeoIP_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 119);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblHost
            // 
            this.lblHost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(3, 82);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(40, 20);
            this.lblHost.TabIndex = 11;
            this.lblHost.Text = "Host";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(98, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(377, 27);
            this.txtName.TabIndex = 13;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // tlpProxyMode
            // 
            this.tlpProxyMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProxyMode.BackColor = System.Drawing.SystemColors.Window;
            this.tlpProxyMode.ColumnCount = 4;
            this.tlpProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpProxyMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpProxyMode.Controls.Add(this.rdoGlobal, 0, 0);
            this.tlpProxyMode.Controls.Add(this.rdoGfwlist, 1, 0);
            this.tlpProxyMode.Controls.Add(this.rdoGeoIP, 2, 0);
            this.tlpProxyMode.Controls.Add(this.rdoNone, 3, 0);
            this.tlpProxyMode.Location = new System.Drawing.Point(98, 189);
            this.tlpProxyMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpProxyMode.Name = "tlpProxyMode";
            this.tlpProxyMode.RowCount = 1;
            this.tlpProxyMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProxyMode.Size = new System.Drawing.Size(377, 31);
            this.tlpProxyMode.TabIndex = 8;
            // 
            // rdoNone
            // 
            this.rdoNone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdoNone.AutoSize = true;
            this.rdoNone.Location = new System.Drawing.Point(308, 3);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(66, 24);
            this.rdoNone.TabIndex = 10;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.CheckedChanged += new System.EventHandler(this.rdoNone_CheckedChanged);
            // 
            // lblProxyMode
            // 
            this.lblProxyMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProxyMode.AutoSize = true;
            this.lblProxyMode.Location = new System.Drawing.Point(3, 194);
            this.lblProxyMode.Name = "lblProxyMode";
            this.lblProxyMode.Size = new System.Drawing.Size(48, 20);
            this.lblProxyMode.TabIndex = 9;
            this.lblProxyMode.Text = "Mode";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoSize = true;
            this.btnRun.Location = new System.Drawing.Point(3, 0);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(153, 30);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(321, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 30);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.AutoSize = true;
            this.btnStop.Location = new System.Drawing.Point(162, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(153, 30);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tlpScheme
            // 
            this.tlpScheme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpScheme.ColumnCount = 3;
            this.tlpScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpScheme.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpScheme.Controls.Add(this.rdoHttps, 0, 0);
            this.tlpScheme.Controls.Add(this.btnQR, 2, 0);
            this.tlpScheme.Controls.Add(this.rdoQuic, 1, 0);
            this.tlpScheme.Location = new System.Drawing.Point(98, 4);
            this.tlpScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpScheme.Name = "tlpScheme";
            this.tlpScheme.RowCount = 1;
            this.tlpScheme.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpScheme.Size = new System.Drawing.Size(377, 29);
            this.tlpScheme.TabIndex = 12;
            // 
            // rdoHttps
            // 
            this.rdoHttps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoHttps.AutoSize = true;
            this.rdoHttps.Checked = true;
            this.rdoHttps.Location = new System.Drawing.Point(3, 4);
            this.rdoHttps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoHttps.Name = "rdoHttps";
            this.rdoHttps.Size = new System.Drawing.Size(73, 21);
            this.rdoHttps.TabIndex = 1;
            this.rdoHttps.TabStop = true;
            this.rdoHttps.Text = "HTTPS";
            this.rdoHttps.UseVisualStyleBackColor = true;
            this.rdoHttps.CheckedChanged += new System.EventHandler(this.rdoHttps_CheckedChanged);
            // 
            // btnQR
            // 
            this.btnQR.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQR.Location = new System.Drawing.Point(338, 0);
            this.btnQR.Margin = new System.Windows.Forms.Padding(0);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(39, 29);
            this.btnQR.TabIndex = 4;
            this.btnQR.Text = "QR";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // rdoQuic
            // 
            this.rdoQuic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoQuic.AutoSize = true;
            this.rdoQuic.Location = new System.Drawing.Point(155, 4);
            this.rdoQuic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoQuic.Name = "rdoQuic";
            this.rdoQuic.Size = new System.Drawing.Size(64, 21);
            this.rdoQuic.TabIndex = 2;
            this.rdoQuic.TabStop = true;
            this.rdoQuic.Text = "QUIC";
            this.rdoQuic.UseVisualStyleBackColor = true;
            this.rdoQuic.CheckedChanged += new System.EventHandler(this.rdoQuic_CheckedChanged);
            // 
            // lblScheme
            // 
            this.lblScheme.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblScheme.AutoSize = true;
            this.lblScheme.Location = new System.Drawing.Point(3, 8);
            this.lblScheme.Name = "lblScheme";
            this.lblScheme.Size = new System.Drawing.Size(61, 20);
            this.lblScheme.TabIndex = 0;
            this.lblScheme.Text = "Scheme";
            // 
            // tlpOperate
            // 
            this.tlpOperate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOperate.AutoSize = true;
            this.tlpOperate.ColumnCount = 3;
            this.tlpOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpOperate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOperate.Controls.Add(this.btnRun, 0, 0);
            this.tlpOperate.Controls.Add(this.btnExit, 2, 0);
            this.tlpOperate.Controls.Add(this.btnStop, 1, 0);
            this.tlpOperate.Location = new System.Drawing.Point(3, 233);
            this.tlpOperate.Name = "tlpOperate";
            this.tlpOperate.RowCount = 1;
            this.tlpOperate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOperate.Size = new System.Drawing.Size(478, 33);
            this.tlpOperate.TabIndex = 13;
            // 
            // lblSave
            // 
            this.lblSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(102, 38);
            this.lblSave.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(96, 30);
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
            this.cmsNotify.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.cmsNotify.Size = new System.Drawing.Size(237, 198);
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
            this.tsmGeoIP,
            this.tsmNone});
            this.tsmMode.Name = "tsmMode";
            this.tsmMode.Size = new System.Drawing.Size(236, 26);
            this.tsmMode.Text = "Proxy Mode";
            // 
            // tsmGlobal
            // 
            this.tsmGlobal.Name = "tsmGlobal";
            this.tsmGlobal.Size = new System.Drawing.Size(145, 26);
            this.tsmGlobal.Text = "Global";
            this.tsmGlobal.Click += new System.EventHandler(this.tsmGlobal_Click);
            // 
            // tsmGFWList
            // 
            this.tsmGFWList.Name = "tsmGFWList";
            this.tsmGFWList.Size = new System.Drawing.Size(145, 26);
            this.tsmGFWList.Text = "GFWList";
            this.tsmGFWList.Click += new System.EventHandler(this.tsmGFWList_Click);
            // 
            // tsmGeoIP
            // 
            this.tsmGeoIP.Name = "tsmGeoIP";
            this.tsmGeoIP.Size = new System.Drawing.Size(145, 26);
            this.tsmGeoIP.Text = "GeoIP";
            this.tsmGeoIP.Click += new System.EventHandler(this.tsmGeoIP_Click);
            // 
            // tsmNone
            // 
            this.tsmNone.Name = "tsmNone";
            this.tsmNone.Size = new System.Drawing.Size(145, 26);
            this.tsmNone.Text = "None";
            this.tsmNone.Click += new System.EventHandler(this.tsmNone_Click);
            // 
            // smiRun
            // 
            this.smiRun.Name = "smiRun";
            this.smiRun.Size = new System.Drawing.Size(236, 26);
            this.smiRun.Text = "Run";
            this.smiRun.Click += new System.EventHandler(this.smiRun_Click);
            // 
            // smiStop
            // 
            this.smiStop.Name = "smiStop";
            this.smiStop.Size = new System.Drawing.Size(236, 26);
            this.smiStop.Text = "Stop";
            this.smiStop.Click += new System.EventHandler(this.smiStop_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(233, 6);
            // 
            // smiCopyShareLink
            // 
            this.smiCopyShareLink.Name = "smiCopyShareLink";
            this.smiCopyShareLink.Size = new System.Drawing.Size(236, 26);
            this.smiCopyShareLink.Text = "Copy your config";
            this.smiCopyShareLink.Click += new System.EventHandler(this.smiCopyShareLink_Click);
            // 
            // smiLoadShareLink
            // 
            this.smiLoadShareLink.Name = "smiLoadShareLink";
            this.smiLoadShareLink.Size = new System.Drawing.Size(236, 26);
            this.smiLoadShareLink.Text = "Load config from clipboard";
            this.smiLoadShareLink.Click += new System.EventHandler(this.smiLoadShareLink_Click);
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(233, 6);
            // 
            // smiAbout
            // 
            this.smiAbout.Name = "smiAbout";
            this.smiAbout.Size = new System.Drawing.Size(236, 26);
            this.smiAbout.Text = "About...";
            this.smiAbout.Click += new System.EventHandler(this.smiAbout_Click);
            // 
            // smiExit
            // 
            this.smiExit.Name = "smiExit";
            this.smiExit.Size = new System.Drawing.Size(236, 26);
            this.smiExit.Text = "Exit";
            this.smiExit.Click += new System.EventHandler(this.smiExit_Click);
            // 
            // tvwNodeList
            // 
            this.tvwNodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwNodeList.HideSelection = false;
            this.tvwNodeList.Location = new System.Drawing.Point(3, 3);
            this.tvwNodeList.Name = "tvwNodeList";
            this.tvwNodeList.Size = new System.Drawing.Size(198, 186);
            this.tvwNodeList.TabIndex = 14;
            this.tvwNodeList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwNodeList_AfterSelect);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(102, 3);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 29);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNode.Location = new System.Drawing.Point(0, 3);
            this.btnAddNode.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(96, 29);
            this.btnAddNode.TabIndex = 0;
            this.btnAddNode.Text = "Add Node";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // lblAddGroup
            // 
            this.lblAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddGroup.Location = new System.Drawing.Point(0, 38);
            this.lblAddGroup.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblAddGroup.Name = "lblAddGroup";
            this.lblAddGroup.Size = new System.Drawing.Size(96, 30);
            this.lblAddGroup.TabIndex = 2;
            this.lblAddGroup.Text = "Add Group";
            this.lblAddGroup.UseVisualStyleBackColor = true;
            this.lblAddGroup.Click += new System.EventHandler(this.lblAddGroup_Click);
            // 
            // tplListControl
            // 
            this.tplListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tplListControl.ColumnCount = 2;
            this.tplListControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplListControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplListControl.Controls.Add(this.lblSave, 1, 1);
            this.tplListControl.Controls.Add(this.btnAddNode, 0, 0);
            this.tplListControl.Controls.Add(this.lblAddGroup, 0, 1);
            this.tplListControl.Controls.Add(this.btnDel, 1, 0);
            this.tplListControl.Location = new System.Drawing.Point(3, 195);
            this.tplListControl.Name = "tplListControl";
            this.tplListControl.RowCount = 2;
            this.tplListControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplListControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tplListControl.Size = new System.Drawing.Size(198, 71);
            this.tplListControl.TabIndex = 16;
            // 
            // tlpInfo
            // 
            this.tlpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpInfo.Controls.Add(this.tlpScheme, 1, 0);
            this.tlpInfo.Controls.Add(this.tlpProxyMode, 1, 5);
            this.tlpInfo.Controls.Add(this.txtPassword, 1, 4);
            this.tlpInfo.Controls.Add(this.lblPassword, 0, 4);
            this.tlpInfo.Controls.Add(this.txtUsername, 1, 3);
            this.tlpInfo.Controls.Add(this.lblScheme, 0, 0);
            this.tlpInfo.Controls.Add(this.txtHost, 1, 2);
            this.tlpInfo.Controls.Add(this.lblName, 0, 1);
            this.tlpInfo.Controls.Add(this.txtName, 1, 1);
            this.tlpInfo.Controls.Add(this.lblUsername, 0, 3);
            this.tlpInfo.Controls.Add(this.lblProxyMode, 0, 5);
            this.tlpInfo.Controls.Add(this.lblHost, 0, 2);
            this.tlpInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 6;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpInfo.Size = new System.Drawing.Size(478, 224);
            this.tlpInfo.TabIndex = 18;
            // 
            // tplControl
            // 
            this.tplControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tplControl.AutoSize = true;
            this.tplControl.ColumnCount = 1;
            this.tplControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplControl.Controls.Add(this.tlpOperate, 0, 1);
            this.tplControl.Controls.Add(this.tlpInfo, 0, 0);
            this.tplControl.Location = new System.Drawing.Point(218, 8);
            this.tplControl.Name = "tplControl";
            this.tplControl.RowCount = 2;
            this.tplControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tplControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tplControl.Size = new System.Drawing.Size(484, 269);
            this.tplControl.TabIndex = 21;
            // 
            // tplNodeList
            // 
            this.tplNodeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tplNodeList.AutoSize = true;
            this.tplNodeList.ColumnCount = 1;
            this.tplNodeList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplNodeList.Controls.Add(this.tplListControl, 0, 1);
            this.tplNodeList.Controls.Add(this.tvwNodeList, 0, 0);
            this.tplNodeList.Location = new System.Drawing.Point(8, 8);
            this.tplNodeList.Name = "tplNodeList";
            this.tplNodeList.RowCount = 2;
            this.tplNodeList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tplNodeList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tplNodeList.Size = new System.Drawing.Size(204, 269);
            this.tplNodeList.TabIndex = 22;
            // 
            // tlpWindow
            // 
            this.tlpWindow.ColumnCount = 4;
            this.tlpWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpWindow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpWindow.Controls.Add(this.tplControl, 2, 1);
            this.tlpWindow.Controls.Add(this.tplNodeList, 1, 1);
            this.tlpWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWindow.Location = new System.Drawing.Point(0, 0);
            this.tlpWindow.Name = "tlpWindow";
            this.tlpWindow.RowCount = 3;
            this.tlpWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWindow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlpWindow.Size = new System.Drawing.Size(715, 285);
            this.tlpWindow.TabIndex = 23;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(715, 285);
            this.Controls.Add(this.tlpWindow);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Naive# 0.6.5 Preview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.tlpProxyMode.ResumeLayout(false);
            this.tlpProxyMode.PerformLayout();
            this.tlpScheme.ResumeLayout(false);
            this.tlpScheme.PerformLayout();
            this.tlpOperate.ResumeLayout(false);
            this.tlpOperate.PerformLayout();
            this.cmsNotify.ResumeLayout(false);
            this.tplListControl.ResumeLayout(false);
            this.tplListControl.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.tplControl.ResumeLayout(false);
            this.tplControl.PerformLayout();
            this.tplNodeList.ResumeLayout(false);
            this.tlpWindow.ResumeLayout(false);
            this.tlpWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.NotifyIcon icnNotify;
        private System.Windows.Forms.Button lblAddGroup;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblProxyMode;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.Label lblScheme;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.RadioButton rdoGeoIP;
        private System.Windows.Forms.RadioButton rdoGfwlist;
        private System.Windows.Forms.RadioButton rdoGlobal;
        public System.Windows.Forms.RadioButton rdoHttps;
        private System.Windows.Forms.RadioButton rdoNone;
        public System.Windows.Forms.RadioButton rdoQuic;
        private System.Windows.Forms.ToolStripMenuItem smiAbout;
        private System.Windows.Forms.ToolStripMenuItem smiCopyShareLink;
        private System.Windows.Forms.ToolStripMenuItem smiExit;
        private System.Windows.Forms.ToolStripMenuItem smiLoadShareLink;
        private System.Windows.Forms.ToolStripMenuItem smiRun;
        private System.Windows.Forms.ToolStripMenuItem smiStop;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TableLayoutPanel tlpOperate;
        private System.Windows.Forms.TableLayoutPanel tlpProxyMode;
        private System.Windows.Forms.TableLayoutPanel tlpScheme;
        private System.Windows.Forms.TableLayoutPanel tlpWindow;
        private System.Windows.Forms.TableLayoutPanel tplControl;
        private System.Windows.Forms.TableLayoutPanel tplListControl;
        private System.Windows.Forms.TableLayoutPanel tplNodeList;
        private System.Windows.Forms.ToolStripMenuItem tsmGeoIP;
        private System.Windows.Forms.ToolStripMenuItem tsmGFWList;
        private System.Windows.Forms.ToolStripMenuItem tsmGlobal;
        private System.Windows.Forms.ToolStripMenuItem tsmMode;
        private System.Windows.Forms.ToolStripMenuItem tsmNone;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.TreeView tvwNodeList;
        public System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;

        #endregion

        private System.Windows.Forms.Button btnQR;
    }
}

