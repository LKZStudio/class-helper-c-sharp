using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using Class_Helper.Database;

namespace Class_Helper
{
    public partial class Settings : Form
    {
        
        Saver saver;
        TimerSmall timerSmall;
        RollCall rollCall;

        /// <summary>
        /// 改变当前已设置时间的值
        /// </summary>
        private void changeDateValue()
        {
            DateTime dt = Utils.GetDateTime(saver.data.Date);
            this.nowTimer.Text = "当前设置：" + dt.ToString();
        }

        // 本窗口相关事件
        public Settings()
        {
            InitializeComponent();
            ConfigJson cj = new ConfigJson();
            cj.NameList = new List<string>();
            cj.TimerName = "一模";
            cj.Date = 1111111111L;
            cj.RollCallMode = 1;
            this.saver = new Saver(cj);
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.timerName.Text = saver.data.TimerName;
            changeDateValue();

            if (saver.data.RollCallMode == 0)
            {
                // 直接抽取
                roll.Checked = false;
                randomImme.Checked = true;
            }
            else if (saver.data.RollCallMode == 1)
            {
                // 滚动抽取
                roll.Checked = true;
                randomImme.Checked = false;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                this.WindowState = FormWindowState.Minimized;
                return;
            }
            base.WndProc(ref m);
        }

        //
        // 托盘事件
        //
        private void icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void 推出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choosePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OpenFD = new OpenFileDialog())
            {
                OpenFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                OpenFD.ShowDialog();
                string fileName = OpenFD.FileName;
                if (fileName == "")
                {
                    MessageBox.Show("请选择路径！", "错误");
                } else if (!fileName.EndsWith(".txt"))
                {
                    MessageBox.Show("不支持的格式！", "错误");
                } else
                {
                    saver.AddNamesByFile(fileName);
                    MessageBox.Show("保存成功！", "信息");
                }
            }
        }

        private void 迷你版ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timerSmall == null || !timerSmall.Visible)
            {
                timerSmall = new TimerSmall();
                timerSmall.Show();
            }
            else
            {
                timerSmall.Close();
                timerSmall = null;
            }
        }

        private void 随机点名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rollCall == null || !rollCall.Visible)
            {
                rollCall = new RollCall();
                rollCall.Show();
            }
            else
            {
                rollCall.Close();
                rollCall = null;
            }
        }

        private void timerNameSubmit_Click(object sender, EventArgs e)
        {
            saver.ChangeTimerName(this.timerName.Text);
            saver.ChangeDate(Utils.GetUnix(this.dateTimePicker1.Value));
            changeDateValue();
        }

        private void clearNameList_Click(object sender, EventArgs e)
        {
            saver.CleanNameList();
            MessageBox.Show("保存成功！", "信息");
        }

        private void randomImme_CheckedChanged(object sender, EventArgs e)
        {
            saver.ChangeRollCallMode(0);
        }

        private void roll_CheckedChanged(object sender, EventArgs e)
        {
            saver.ChangeRollCallMode(1);
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
