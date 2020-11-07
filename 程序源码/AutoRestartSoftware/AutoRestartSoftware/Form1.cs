using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace AutoRestartSofeware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                txtSoftwarePath.Text = GetValue("softwarePath");
                txtSoftwareName.Text = GetValue("softwareName");
                bool startWithWindows;
                chkStartWithWindows.Checked = bool.TryParse(GetValue("startWithWindows"), out startWithWindows) ? startWithWindows : false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化异常："+ex);
            }

            
        }

        private void btnSelectSoftwarePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "可执行文件|*.exe";
            if (ofg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSoftwarePath.Text = ofg.FileName;
                txtSoftwareName.Text = Path.GetFileNameWithoutExtension(ofg.FileName);
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoftwarePath.Text.Trim() != "" && txtSoftwareName.Text.Trim() != "")
                {
                    SetValue("softwarePath", txtSoftwarePath.Text);
                    SetValue("softwareName", txtSoftwareName.Text);
                    if (HelpTools.ProjectTool.SetComputerStartRun(Application.ExecutablePath, chkStartWithWindows.Checked))
                    {
                        SetValue("startWithWindows", chkStartWithWindows.Checked.ToString());
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("设置开机状态失败");
                    }
                }
                else
                {
                    MessageBox.Show("有未填写项");
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存异常："+ex);
            }
        }

        /// <summary>  
        /// 写入值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <param name="value"></param>  
        public static void SetValue(string key, string value)
        {
            //增加的内容写在appSettings段下 <add key="RegCode" value="0"/>  
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   
        }

        /// <summary>  
        /// 读取指定key的值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static string GetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            Application.Exit();
            Environment.Exit(0);
        }

        private void tsmShow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }

        private void tsmHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void niAutoRestartSoftware_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CheckRun.CheckAndOpenExe(txtSoftwareName.Text, txtSoftwarePath.Text);
        }
    }
}
