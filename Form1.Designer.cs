
namespace Class_Helper
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.随机点名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倒计时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.迷你版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.推出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.choosePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timerNameSubmit = new System.Windows.Forms.Button();
            this.timerName = new System.Windows.Forms.TextBox();
            this.nowTimer = new System.Windows.Forms.Label();
            this.clearNameList = new System.Windows.Forms.Button();
            this.randomImme = new System.Windows.Forms.RadioButton();
            this.roll = new System.Windows.Forms.RadioButton();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.随机点名ToolStripMenuItem,
            this.倒计时ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.推出ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip3";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 128);
            // 
            // 随机点名ToolStripMenuItem
            // 
            this.随机点名ToolStripMenuItem.Name = "随机点名ToolStripMenuItem";
            this.随机点名ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.随机点名ToolStripMenuItem.Text = "随机点名";
            this.随机点名ToolStripMenuItem.Click += new System.EventHandler(this.随机点名ToolStripMenuItem_Click);
            // 
            // 倒计时ToolStripMenuItem
            // 
            this.倒计时ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.迷你版ToolStripMenuItem});
            this.倒计时ToolStripMenuItem.Name = "倒计时ToolStripMenuItem";
            this.倒计时ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.倒计时ToolStripMenuItem.Text = "倒计时";
            // 
            // 迷你版ToolStripMenuItem
            // 
            this.迷你版ToolStripMenuItem.Name = "迷你版ToolStripMenuItem";
            this.迷你版ToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.迷你版ToolStripMenuItem.Text = "迷你版";
            this.迷你版ToolStripMenuItem.Click += new System.EventHandler(this.迷你版ToolStripMenuItem_Click);
            // 
            // 推出ToolStripMenuItem
            // 
            this.推出ToolStripMenuItem.Name = "推出ToolStripMenuItem";
            this.推出ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.推出ToolStripMenuItem.Text = "退出";
            this.推出ToolStripMenuItem.Click += new System.EventHandler(this.推出ToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icon_MouseDoubleClick);
            // 
            // choosePath
            // 
            this.choosePath.BackColor = System.Drawing.Color.OrangeRed;
            this.choosePath.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choosePath.Location = new System.Drawing.Point(265, 19);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(288, 86);
            this.choosePath.TabIndex = 1;
            this.choosePath.Text = "选择名单路径";
            this.choosePath.UseVisualStyleBackColor = false;
            this.choosePath.Click += new System.EventHandler(this.choosePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "点名器设置：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "倒计时设置：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 25);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // timerNameSubmit
            // 
            this.timerNameSubmit.Location = new System.Drawing.Point(478, 130);
            this.timerNameSubmit.Name = "timerNameSubmit";
            this.timerNameSubmit.Size = new System.Drawing.Size(75, 49);
            this.timerNameSubmit.TabIndex = 5;
            this.timerNameSubmit.Text = "储存";
            this.timerNameSubmit.UseVisualStyleBackColor = true;
            this.timerNameSubmit.Click += new System.EventHandler(this.timerNameSubmit_Click);
            // 
            // timerName
            // 
            this.timerName.Location = new System.Drawing.Point(265, 144);
            this.timerName.Name = "timerName";
            this.timerName.Size = new System.Drawing.Size(207, 25);
            this.timerName.TabIndex = 6;
            // 
            // nowTimer
            // 
            this.nowTimer.AutoSize = true;
            this.nowTimer.Font = new System.Drawing.Font("阿里巴巴普惠体 L", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nowTimer.Location = new System.Drawing.Point(260, 182);
            this.nowTimer.Name = "nowTimer";
            this.nowTimer.Size = new System.Drawing.Size(240, 26);
            this.nowTimer.TabIndex = 7;
            this.nowTimer.Text = "您还尚未设置倒计时时间！";
            // 
            // clearNameList
            // 
            this.clearNameList.BackColor = System.Drawing.Color.OrangeRed;
            this.clearNameList.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearNameList.Location = new System.Drawing.Point(559, 19);
            this.clearNameList.Name = "clearNameList";
            this.clearNameList.Size = new System.Drawing.Size(205, 86);
            this.clearNameList.TabIndex = 8;
            this.clearNameList.Text = "清除名单";
            this.clearNameList.UseVisualStyleBackColor = false;
            this.clearNameList.Click += new System.EventHandler(this.clearNameList_Click);
            // 
            // randomImme
            // 
            this.randomImme.AutoSize = true;
            this.randomImme.Location = new System.Drawing.Point(265, 111);
            this.randomImme.Name = "randomImme";
            this.randomImme.Size = new System.Drawing.Size(88, 19);
            this.randomImme.TabIndex = 11;
            this.randomImme.Text = "直接抽取";
            this.randomImme.UseVisualStyleBackColor = true;
            this.randomImme.CheckedChanged += new System.EventHandler(this.randomImme_CheckedChanged);
            // 
            // roll
            // 
            this.roll.AutoSize = true;
            this.roll.Checked = true;
            this.roll.Location = new System.Drawing.Point(359, 111);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(88, 19);
            this.roll.TabIndex = 12;
            this.roll.TabStop = true;
            this.roll.Text = "滚动抽取";
            this.roll.UseVisualStyleBackColor = true;
            this.roll.CheckedChanged += new System.EventHandler(this.roll_CheckedChanged);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.设置ToolStripMenuItem.Text = "设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 452);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.randomImme);
            this.Controls.Add(this.clearNameList);
            this.Controls.Add(this.nowTimer);
            this.Controls.Add(this.timerName);
            this.Controls.Add(this.timerNameSubmit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choosePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "班级助手";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 随机点名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倒计时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 迷你版ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 推出ToolStripMenuItem;
        private System.Windows.Forms.Button choosePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button timerNameSubmit;
        private System.Windows.Forms.TextBox timerName;
        private System.Windows.Forms.Label nowTimer;
        private System.Windows.Forms.Button clearNameList;
        private System.Windows.Forms.RadioButton randomImme;
        private System.Windows.Forms.RadioButton roll;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
    }
}

