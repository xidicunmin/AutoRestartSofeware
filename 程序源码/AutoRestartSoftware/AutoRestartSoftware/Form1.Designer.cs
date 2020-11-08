namespace AutoRestartSofeware
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSoftwarePath = new System.Windows.Forms.TextBox();
            this.lblSofewarePath = new System.Windows.Forms.Label();
            this.btnSelectSoftwarePath = new System.Windows.Forms.Button();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.niAutoRestartSoftware = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsAutoRestartSoftware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoftwareName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.cmsAutoRestartSoftware.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSoftwarePath
            // 
            this.txtSoftwarePath.Enabled = false;
            this.txtSoftwarePath.Location = new System.Drawing.Point(84, 20);
            this.txtSoftwarePath.Name = "txtSoftwarePath";
            this.txtSoftwarePath.Size = new System.Drawing.Size(216, 21);
            this.txtSoftwarePath.TabIndex = 0;
            // 
            // lblSofewarePath
            // 
            this.lblSofewarePath.AutoSize = true;
            this.lblSofewarePath.Location = new System.Drawing.Point(13, 23);
            this.lblSofewarePath.Name = "lblSofewarePath";
            this.lblSofewarePath.Size = new System.Drawing.Size(65, 12);
            this.lblSofewarePath.TabIndex = 1;
            this.lblSofewarePath.Text = "程序路径：";
            // 
            // btnSelectSoftwarePath
            // 
            this.btnSelectSoftwarePath.Location = new System.Drawing.Point(306, 18);
            this.btnSelectSoftwarePath.Name = "btnSelectSoftwarePath";
            this.btnSelectSoftwarePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSoftwarePath.TabIndex = 2;
            this.btnSelectSoftwarePath.Text = "选择程序";
            this.btnSelectSoftwarePath.UseVisualStyleBackColor = true;
            this.btnSelectSoftwarePath.Click += new System.EventHandler(this.btnSelectSoftwarePath_Click);
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Location = new System.Drawing.Point(15, 72);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(72, 16);
            this.chkStartWithWindows.TabIndex = 3;
            this.chkStartWithWindows.Text = "开机启动";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(306, 68);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 4;
            this.btnSaveConfig.Text = "保存";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // niAutoRestartSoftware
            // 
            this.niAutoRestartSoftware.ContextMenuStrip = this.cmsAutoRestartSoftware;
            this.niAutoRestartSoftware.Icon = ((System.Drawing.Icon)(resources.GetObject("niAutoRestartSoftware.Icon")));
            this.niAutoRestartSoftware.Text = "退出自动重启";
            this.niAutoRestartSoftware.Visible = true;
            this.niAutoRestartSoftware.DoubleClick += new System.EventHandler(this.niAutoRestartSoftware_DoubleClick);
            // 
            // cmsAutoRestartSoftware
            // 
            this.cmsAutoRestartSoftware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShow,
            this.tsmHide,
            this.toolStripSeparator1,
            this.tsmClose});
            this.cmsAutoRestartSoftware.Name = "cmsAutoRestartSoftware";
            this.cmsAutoRestartSoftware.Size = new System.Drawing.Size(125, 76);
            // 
            // tsmShow
            // 
            this.tsmShow.Name = "tsmShow";
            this.tsmShow.Size = new System.Drawing.Size(124, 22);
            this.tsmShow.Text = "显示界面";
            this.tsmShow.Click += new System.EventHandler(this.tsmShow_Click);
            // 
            // tsmHide
            // 
            this.tsmHide.Name = "tsmHide";
            this.tsmHide.Size = new System.Drawing.Size(124, 22);
            this.tsmHide.Text = "隐藏界面";
            this.tsmHide.Click += new System.EventHandler(this.tsmHide_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(124, 22);
            this.tsmClose.Text = "退出";
            this.tsmClose.Click += new System.EventHandler(this.tsmClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "进程名称：";
            // 
            // txtSoftwareName
            // 
            this.txtSoftwareName.Location = new System.Drawing.Point(84, 44);
            this.txtSoftwareName.Name = "txtSoftwareName";
            this.txtSoftwareName.Size = new System.Drawing.Size(123, 21);
            this.txtSoftwareName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "（任务管理器查看对应进程名称）";
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Checked = true;
            this.chkStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStart.Location = new System.Drawing.Point(93, 72);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(72, 16);
            this.chkStart.TabIndex = 8;
            this.chkStart.Text = "监控程序";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.CheckedChanged += new System.EventHandler(this.chkStart_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 102);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoftwareName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.chkStartWithWindows);
            this.Controls.Add(this.btnSelectSoftwarePath);
            this.Controls.Add(this.lblSofewarePath);
            this.Controls.Add(this.txtSoftwarePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 141);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 141);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "退出自动重启";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.cmsAutoRestartSoftware.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoftwarePath;
        private System.Windows.Forms.Label lblSofewarePath;
        private System.Windows.Forms.Button btnSelectSoftwarePath;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.NotifyIcon niAutoRestartSoftware;
        private System.Windows.Forms.ContextMenuStrip cmsAutoRestartSoftware;
        private System.Windows.Forms.ToolStripMenuItem tsmShow;
        private System.Windows.Forms.ToolStripMenuItem tsmHide;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoftwareName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkStart;
    }
}

