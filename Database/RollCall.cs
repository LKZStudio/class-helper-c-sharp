using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Class_Helper.Database
{
    public partial class RollCall : Form
    {
        Saver saver = new Saver(new ConfigJson());
        List<string> names;
        bool noRepeatVar;
        int type;
        int key = 0;

        private void ResetNames()
        {
            names = new List<string>();
            saver.data.NameList.ForEach(i => names.Add(i));

            // 也可以这样
            // names = new List<string>(saver.data.NameList.ToArray());
        }

        private void GetNextPerson()
        {
            if (names.Count <= 0)
            {
                ResetNames();
            }
            if (type == 0)
            {
                // 直接抽取
                key = Utils.RandomNum(0, names.Count - 1);
                nameLabel.Text = names[key];
            }
            else if (type == 1)
            {
                // 随机抽取
                if (key < (names.Count - 1))
                {
                    key += 1;
                }
                else
                {
                    key = 0;
                }
                nameLabel.Text = names[key];
            }
        }
        public RollCall()
        {
            InitializeComponent();
            ResetNames();
            noRepeatVar = !noRepeat.Checked;
        }

        private void RollCall_Load(object sender, EventArgs e)
        {
            type = saver.data.RollCallMode;
            if (type == 0)
            {
                rollBtn.Text = "抽取";
            }
            else if (type == 1)
            {
                rollBtn.Text = "开始抽取";
            }
            UpdateNoRepeatText();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            if (rollBtn.Text == "抽取")
            {
                GetNextPerson();
                if (noRepeatVar)
                {
                    names.RemoveAt(key);
                }
                UpdateNoRepeatText();
            }
            else if (rollBtn.Text == "开始抽取")
            {
                timer1.Enabled = true;
                rollBtn.Text = "停止抽取";
            }
            else if (rollBtn.Text == "停止抽取")
            {
                timer1.Enabled = false;
                rollBtn.Text = "开始抽取";
                if (noRepeatVar)
                {
                    names.RemoveAt(key);
                }
                UpdateNoRepeatText();
            }
        }

        private void noRepeat_CheckedChanged(object sender, EventArgs e)
        {
            noRepeatVar = !noRepeat.Checked;
            UpdateNoRepeatText();
        }

        private void UpdateNoRepeatText()
        {
            if (noRepeatVar)
            {
                noRepeat.Text = "重复抽选（本轮还剩 " + names.Count + " 人未抽选）";
            }
            else
            {
                noRepeat.Text = "重复抽选";
                ResetNames();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetNextPerson();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numericUpDown1.Value;
        }
    }
}
