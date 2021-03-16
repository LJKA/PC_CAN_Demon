namespace WindowsFormsApp1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_Mode = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_AccMask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Time1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Time0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_AccCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_CANindex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Devindex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_Devtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.button_StartCAN = new System.Windows.Forms.Button();
            this.button_StopCAN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_Data = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_FrameFormat = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_FrameType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_SendType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_Info = new System.Windows.Forms.ListBox();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox_CANindex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Devindex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combox_Devtype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备参数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_Mode);
            this.groupBox2.Controls.Add(this.comboBox_Filter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_AccMask);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_Time1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Time0);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_AccCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "初始化参数";
            // 
            // comboBox_Mode
            // 
            this.comboBox_Mode.FormattingEnabled = true;
            this.comboBox_Mode.Items.AddRange(new object[] {
            "正常",
            "只听"});
            this.comboBox_Mode.Location = new System.Drawing.Point(378, 36);
            this.comboBox_Mode.Name = "comboBox_Mode";
            this.comboBox_Mode.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Mode.TabIndex = 11;
            // 
            // comboBox_Filter
            // 
            this.comboBox_Filter.FormattingEnabled = true;
            this.comboBox_Filter.Items.AddRange(new object[] {
            "单滤波",
            "双滤波"});
            this.comboBox_Filter.Location = new System.Drawing.Point(378, 8);
            this.comboBox_Filter.Name = "comboBox_Filter";
            this.comboBox_Filter.Size = new System.Drawing.Size(71, 20);
            this.comboBox_Filter.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "模式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "滤波方式：";
            // 
            // textBox_AccMask
            // 
            this.textBox_AccMask.Location = new System.Drawing.Point(78, 35);
            this.textBox_AccMask.Name = "textBox_AccMask";
            this.textBox_AccMask.Size = new System.Drawing.Size(70, 21);
            this.textBox_AccMask.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "屏蔽码：0x";
            // 
            // textBox_Time1
            // 
            this.textBox_Time1.Location = new System.Drawing.Point(231, 35);
            this.textBox_Time1.Name = "textBox_Time1";
            this.textBox_Time1.Size = new System.Drawing.Size(70, 21);
            this.textBox_Time1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "定时器1：0x";
            // 
            // textBox_Time0
            // 
            this.textBox_Time0.Location = new System.Drawing.Point(231, 8);
            this.textBox_Time0.Name = "textBox_Time0";
            this.textBox_Time0.Size = new System.Drawing.Size(70, 21);
            this.textBox_Time0.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "定时器0：0x";
            // 
            // textBox_AccCode
            // 
            this.textBox_AccCode.Location = new System.Drawing.Point(77, 8);
            this.textBox_AccCode.Name = "textBox_AccCode";
            this.textBox_AccCode.Size = new System.Drawing.Size(70, 21);
            this.textBox_AccCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "验证码：0x";
            // 
            // comboBox_CANindex
            // 
            this.comboBox_CANindex.FormattingEnabled = true;
            this.comboBox_CANindex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBox_CANindex.Location = new System.Drawing.Point(395, 14);
            this.comboBox_CANindex.Name = "comboBox_CANindex";
            this.comboBox_CANindex.Size = new System.Drawing.Size(41, 20);
            this.comboBox_CANindex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "第几路CAN：";
            // 
            // comboBox_Devindex
            // 
            this.comboBox_Devindex.FormattingEnabled = true;
            this.comboBox_Devindex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox_Devindex.Location = new System.Drawing.Point(248, 14);
            this.comboBox_Devindex.Name = "comboBox_Devindex";
            this.comboBox_Devindex.Size = new System.Drawing.Size(41, 20);
            this.comboBox_Devindex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "索引号：";
            // 
            // combox_Devtype
            // 
            this.combox_Devtype.BackColor = System.Drawing.Color.White;
            this.combox_Devtype.FormattingEnabled = true;
            this.combox_Devtype.Items.AddRange(new object[] {
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
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.combox_Devtype.Location = new System.Drawing.Point(50, 14);
            this.combox_Devtype.Name = "combox_Devtype";
            this.combox_Devtype.Size = new System.Drawing.Size(115, 20);
            this.combox_Devtype.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型：";
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(516, 24);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonconnect.TabIndex = 1;
            this.buttonconnect.Text = "连接";
            this.buttonconnect.UseVisualStyleBackColor = true;
            // 
            // button_StartCAN
            // 
            this.button_StartCAN.Location = new System.Drawing.Point(516, 57);
            this.button_StartCAN.Name = "button_StartCAN";
            this.button_StartCAN.Size = new System.Drawing.Size(75, 23);
            this.button_StartCAN.TabIndex = 2;
            this.button_StartCAN.Text = "启动CAN";
            this.button_StartCAN.UseVisualStyleBackColor = true;
            this.button_StartCAN.Click += new System.EventHandler(this.button_StartCAN_Click);
            // 
            // button_StopCAN
            // 
            this.button_StopCAN.Location = new System.Drawing.Point(516, 91);
            this.button_StopCAN.Name = "button_StopCAN";
            this.button_StopCAN.Size = new System.Drawing.Size(75, 23);
            this.button_StopCAN.TabIndex = 3;
            this.button_StopCAN.Text = "复位CAN";
            this.button_StopCAN.UseVisualStyleBackColor = true;
            this.button_StopCAN.Click += new System.EventHandler(this.button_StopCAN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_send);
            this.groupBox3.Controls.Add(this.textBox_Data);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox_ID);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.comboBox_FrameFormat);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBox_FrameType);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comboBox_SendType);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 112);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据帧";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(504, 51);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_Data
            // 
            this.textBox_Data.Location = new System.Drawing.Point(84, 53);
            this.textBox_Data.Name = "textBox_Data";
            this.textBox_Data.Size = new System.Drawing.Size(391, 21);
            this.textBox_Data.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "数据：";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(543, 18);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(70, 21);
            this.textBox_ID.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "帧ID 0x：";
            // 
            // comboBox_FrameFormat
            // 
            this.comboBox_FrameFormat.FormattingEnabled = true;
            this.comboBox_FrameFormat.Items.AddRange(new object[] {
            "数据帧",
            "远程帧"});
            this.comboBox_FrameFormat.Location = new System.Drawing.Point(395, 19);
            this.comboBox_FrameFormat.Name = "comboBox_FrameFormat";
            this.comboBox_FrameFormat.Size = new System.Drawing.Size(80, 20);
            this.comboBox_FrameFormat.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "帧格式：";
            // 
            // comboBox_FrameType
            // 
            this.comboBox_FrameType.FormattingEnabled = true;
            this.comboBox_FrameType.Items.AddRange(new object[] {
            "标准帧",
            "扩展帧"});
            this.comboBox_FrameType.Location = new System.Drawing.Point(238, 19);
            this.comboBox_FrameType.Name = "comboBox_FrameType";
            this.comboBox_FrameType.Size = new System.Drawing.Size(80, 20);
            this.comboBox_FrameType.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "帧类型：";
            // 
            // comboBox_SendType
            // 
            this.comboBox_SendType.FormattingEnabled = true;
            this.comboBox_SendType.Items.AddRange(new object[] {
            "正常发送",
            "单次正常发送",
            "自发自收",
            "单次自发自收"});
            this.comboBox_SendType.Location = new System.Drawing.Point(84, 20);
            this.comboBox_SendType.Name = "comboBox_SendType";
            this.comboBox_SendType.Size = new System.Drawing.Size(80, 20);
            this.comboBox_SendType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "发送格式：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_Info);
            this.groupBox4.Location = new System.Drawing.Point(13, 263);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 175);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "信息";
            // 
            // listBox_Info
            // 
            this.listBox_Info.BackColor = System.Drawing.SystemColors.Info;
            this.listBox_Info.FormattingEnabled = true;
            this.listBox_Info.ItemHeight = 12;
            this.listBox_Info.Location = new System.Drawing.Point(7, 21);
            this.listBox_Info.Name = "listBox_Info";
            this.listBox_Info.Size = new System.Drawing.Size(609, 148);
            this.listBox_Info.TabIndex = 0;
            // 
            // timer_rec
            // 
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_StopCAN);
            this.Controls.Add(this.button_StartCAN);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CAN通用测试例子";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combox_Devtype;
        private System.Windows.Forms.ComboBox comboBox_Devindex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_CANindex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_AccCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Time0;
        private System.Windows.Forms.TextBox textBox_Time1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Mode;
        private System.Windows.Forms.ComboBox comboBox_Filter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_AccMask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.Button button_StartCAN;
        private System.Windows.Forms.Button button_StopCAN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_Data;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_FrameFormat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_FrameType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_SendType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBox_Info;
        private System.Windows.Forms.Timer timer_rec;
    }
}

