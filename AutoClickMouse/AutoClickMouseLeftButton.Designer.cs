namespace AutoClickMouse
{
    partial class AutoClickMouseLeftButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClickMouseLeftButton));
            this.BT_Start = new System.Windows.Forms.Button();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DP_SleepTime = new System.Windows.Forms.ComboBox();
            this.RB_Left = new System.Windows.Forms.RadioButton();
            this.RB_Right = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(25, 95);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(75, 23);
            this.BT_Start.TabIndex = 1;
            this.BT_Start.Text = "开始(F9)";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Location = new System.Drawing.Point(181, 95);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(75, 23);
            this.BT_Stop.TabIndex = 2;
            this.BT_Stop.Text = "结束(F10)";
            this.BT_Stop.UseVisualStyleBackColor = true;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "鼠标点击类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "秒";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "点击间隔时间：";
            // 
            // DP_SleepTime
            // 
            this.DP_SleepTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DP_SleepTime.FormattingEnabled = true;
            this.DP_SleepTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.DP_SleepTime.Location = new System.Drawing.Point(121, 54);
            this.DP_SleepTime.Name = "DP_SleepTime";
            this.DP_SleepTime.Size = new System.Drawing.Size(113, 20);
            this.DP_SleepTime.TabIndex = 11;
            // 
            // RB_Left
            // 
            this.RB_Left.AutoSize = true;
            this.RB_Left.Checked = true;
            this.RB_Left.Location = new System.Drawing.Point(121, 17);
            this.RB_Left.Name = "RB_Left";
            this.RB_Left.Size = new System.Drawing.Size(47, 16);
            this.RB_Left.TabIndex = 12;
            this.RB_Left.TabStop = true;
            this.RB_Left.Text = "左键";
            this.RB_Left.UseVisualStyleBackColor = true;
            // 
            // RB_Right
            // 
            this.RB_Right.AutoSize = true;
            this.RB_Right.Location = new System.Drawing.Point(187, 17);
            this.RB_Right.Name = "RB_Right";
            this.RB_Right.Size = new System.Drawing.Size(47, 16);
            this.RB_Right.TabIndex = 13;
            this.RB_Right.Text = "右键";
            this.RB_Right.UseVisualStyleBackColor = true;
            // 
            // AutoClickMouseLeftButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.RB_Right);
            this.Controls.Add(this.RB_Left);
            this.Controls.Add(this.DP_SleepTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Stop);
            this.Controls.Add(this.BT_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoClickMouseLeftButton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鼠标自动点击器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoClickMouseLeftButton_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DP_SleepTime;
        private System.Windows.Forms.RadioButton RB_Left;
        private System.Windows.Forms.RadioButton RB_Right;
    }
}

