using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Class_Helper.Database;

namespace Class_Helper
{
    public partial class TimerSmall : Form
    {
        Saver saver = new Saver(new ConfigJson());
        public TimerSmall()
        {
            InitializeComponent();
        }

        private void TimerSmall_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Left = 0;
            this.Top = 0;
            nameLabel.Text = saver.data.TimerName;
        }


        //
        // 窗口拖动
        //
        bool beginMove = false;
        int currentXPosition;
        int currentYPosition;

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;
                this.Top += MousePosition.Y - currentYPosition;
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void onMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0;
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimerSmall_Paint(object sender, PaintEventArgs e)
        {
            Rectangle tang = this.ClientRectangle;
            Graphics g3 = e.Graphics;
            Color c3 = Color.FromArgb(211, 183, 142);
            Pen p3 = new Pen(c3, 30.0f);
            g3.DrawLine(p3, 0, 0, 0, tang.Height - 1);
            g3.DrawLine(p3, 0, tang.Height - 1, tang.Width - 1, tang.Height - 1);
            g3.DrawLine(p3, tang.Width - 1, tang.Height - 1, tang.Width - 1, 0);
            g3.DrawLine(p3, tang.Width - 1, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] diff = Utils.DateDiff(Utils.GetDateTime(saver.data.Date), DateTime.Now);

            daysNumLabel.Text = diff[0];
            hoursNumLabel.Text = diff[1];
            minutesNumLabel.Text = diff[2];
            secondsNumLabel.Text = diff[3];
        }

        private void TimerSmall_Activated(object sender, EventArgs e)
        {

        }
    }
}
