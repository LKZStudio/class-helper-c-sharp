
namespace Class_Helper
{
    partial class TimerSmall
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerSmall));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.daysNumLabel = new System.Windows.Forms.Label();
            this.hoursNumLabel = new System.Windows.Forms.Label();
            this.minutesNumLabel = new System.Windows.Forms.Label();
            this.secondsNumLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "倒计时：";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 L", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daysLabel.ForeColor = System.Drawing.Color.White;
            this.daysLabel.Location = new System.Drawing.Point(260, 49);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(48, 41);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "天";
            this.daysLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.daysLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.daysLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 L", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hoursLabel.ForeColor = System.Drawing.Color.White;
            this.hoursLabel.Location = new System.Drawing.Point(374, 49);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(48, 41);
            this.hoursLabel.TabIndex = 3;
            this.hoursLabel.Text = "时";
            this.hoursLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.hoursLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.hoursLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 L", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minutesLabel.ForeColor = System.Drawing.Color.White;
            this.minutesLabel.Location = new System.Drawing.Point(489, 49);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(48, 41);
            this.minutesLabel.TabIndex = 4;
            this.minutesLabel.Text = "分";
            this.minutesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.minutesLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.minutesLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 L", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secondsLabel.ForeColor = System.Drawing.Color.White;
            this.secondsLabel.Location = new System.Drawing.Point(604, 49);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(48, 41);
            this.secondsLabel.TabIndex = 5;
            this.secondsLabel.Text = "秒";
            this.secondsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.secondsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.secondsLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // daysNumLabel
            // 
            this.daysNumLabel.AutoSize = true;
            this.daysNumLabel.BackColor = System.Drawing.Color.White;
            this.daysNumLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daysNumLabel.ForeColor = System.Drawing.Color.Red;
            this.daysNumLabel.Location = new System.Drawing.Point(165, 38);
            this.daysNumLabel.Name = "daysNumLabel";
            this.daysNumLabel.Size = new System.Drawing.Size(89, 52);
            this.daysNumLabel.TabIndex = 6;
            this.daysNumLabel.Text = "333";
            this.daysNumLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.daysNumLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.daysNumLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // hoursNumLabel
            // 
            this.hoursNumLabel.AutoSize = true;
            this.hoursNumLabel.BackColor = System.Drawing.Color.White;
            this.hoursNumLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hoursNumLabel.ForeColor = System.Drawing.Color.Red;
            this.hoursNumLabel.Location = new System.Drawing.Point(301, 38);
            this.hoursNumLabel.Name = "hoursNumLabel";
            this.hoursNumLabel.Size = new System.Drawing.Size(67, 52);
            this.hoursNumLabel.TabIndex = 7;
            this.hoursNumLabel.Text = "23";
            this.hoursNumLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.hoursNumLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.hoursNumLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // minutesNumLabel
            // 
            this.minutesNumLabel.AutoSize = true;
            this.minutesNumLabel.BackColor = System.Drawing.Color.White;
            this.minutesNumLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minutesNumLabel.ForeColor = System.Drawing.Color.Red;
            this.minutesNumLabel.Location = new System.Drawing.Point(416, 38);
            this.minutesNumLabel.Name = "minutesNumLabel";
            this.minutesNumLabel.Size = new System.Drawing.Size(67, 52);
            this.minutesNumLabel.TabIndex = 8;
            this.minutesNumLabel.Text = "23";
            this.minutesNumLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.minutesNumLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.minutesNumLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // secondsNumLabel
            // 
            this.secondsNumLabel.AutoSize = true;
            this.secondsNumLabel.BackColor = System.Drawing.Color.White;
            this.secondsNumLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.secondsNumLabel.ForeColor = System.Drawing.Color.Red;
            this.secondsNumLabel.Location = new System.Drawing.Point(531, 38);
            this.secondsNumLabel.Name = "secondsNumLabel";
            this.secondsNumLabel.Size = new System.Drawing.Size(67, 52);
            this.secondsNumLabel.TabIndex = 9;
            this.secondsNumLabel.Text = "23";
            this.secondsNumLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.secondsNumLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.secondsNumLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("阿里巴巴普惠体 B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(21, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 41);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "中考";
            this.nameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.nameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.nameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(87)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(683, 127);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.secondsNumLabel);
            this.Controls.Add(this.minutesNumLabel);
            this.Controls.Add(this.hoursNumLabel);
            this.Controls.Add(this.daysNumLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerSmall";
            this.Text = "TimerSmall";
            this.Activated += new System.EventHandler(this.TimerSmall_Activated);
            this.Load += new System.EventHandler(this.TimerSmall_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TimerSmall_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.onMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.onMouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label daysNumLabel;
        private System.Windows.Forms.Label hoursNumLabel;
        private System.Windows.Forms.Label minutesNumLabel;
        private System.Windows.Forms.Label secondsNumLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Timer timer1;
    }
}