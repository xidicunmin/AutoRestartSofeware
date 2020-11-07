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
            this.txtSoftwarePath = new System.Windows.Forms.TextBox();
            this.lblSofewarePath = new System.Windows.Forms.Label();
            this.btnSelectSoftwarePath = new System.Windows.Forms.Button();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnSaveConfig = new System.Windows.Forms.Button();
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
            this.chkStartWithWindows.Location = new System.Drawing.Point(15, 51);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(72, 16);
            this.chkStartWithWindows.TabIndex = 3;
            this.chkStartWithWindows.Text = "开机启动";
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(306, 47);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConfig.TabIndex = 4;
            this.btnSaveConfig.Text = "保存";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 81);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.chkStartWithWindows);
            this.Controls.Add(this.btnSelectSoftwarePath);
            this.Controls.Add(this.lblSofewarePath);
            this.Controls.Add(this.txtSoftwarePath);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(410, 120);
            this.MinimumSize = new System.Drawing.Size(410, 120);
            this.Name = "Form1";
            this.Text = "退出自动重启";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoftwarePath;
        private System.Windows.Forms.Label lblSofewarePath;
        private System.Windows.Forms.Button btnSelectSoftwarePath;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.Button btnSaveConfig;
    }
}

