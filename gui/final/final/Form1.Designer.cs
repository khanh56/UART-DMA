
namespace final
{
    partial class txt_receive_data
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.cbb_select_com = new System.Windows.Forms.ComboBox();
            this.cbb_select_baud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_datasize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_parity = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_led2 = new System.Windows.Forms.CheckBox();
            this.cb_led1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_led15 = new System.Windows.Forms.CheckBox();
            this.cb_led14 = new System.Windows.Forms.CheckBox();
            this.txt_syn = new System.Windows.Forms.TextBox();
            this.Handshake = new System.Windows.Forms.GroupBox();
            this.txt_ack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emergency = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_adc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Handshake.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(58, 181);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(152, 38);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "CONNECT";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_select_com
            // 
            this.cbb_select_com.FormattingEnabled = true;
            this.cbb_select_com.Location = new System.Drawing.Point(101, 37);
            this.cbb_select_com.Name = "cbb_select_com";
            this.cbb_select_com.Size = new System.Drawing.Size(141, 24);
            this.cbb_select_com.TabIndex = 1;
            this.cbb_select_com.Text = "COM5";
            // 
            // cbb_select_baud
            // 
            this.cbb_select_baud.FormattingEnabled = true;
            this.cbb_select_baud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbb_select_baud.Location = new System.Drawing.Point(101, 67);
            this.cbb_select_baud.Name = "cbb_select_baud";
            this.cbb_select_baud.Size = new System.Drawing.Size(141, 24);
            this.cbb_select_baud.TabIndex = 1;
            this.cbb_select_baud.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud";
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 8;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datasize";
            // 
            // cbb_datasize
            // 
            this.cbb_datasize.FormattingEnabled = true;
            this.cbb_datasize.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cbb_datasize.Location = new System.Drawing.Point(101, 101);
            this.cbb_datasize.Name = "cbb_datasize";
            this.cbb_datasize.Size = new System.Drawing.Size(141, 24);
            this.cbb_datasize.TabIndex = 1;
            this.cbb_datasize.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // cbb_parity
            // 
            this.cbb_parity.FormattingEnabled = true;
            this.cbb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbb_parity.Location = new System.Drawing.Point(101, 134);
            this.cbb_parity.Name = "cbb_parity";
            this.cbb_parity.Size = new System.Drawing.Size(141, 24);
            this.cbb_parity.TabIndex = 1;
            this.cbb_parity.Text = "None";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_connect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_select_com);
            this.groupBox2.Controls.Add(this.cbb_select_baud);
            this.groupBox2.Controls.Add(this.cbb_datasize);
            this.groupBox2.Controls.Add(this.cbb_parity);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 235);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // cb_led2
            // 
            this.cb_led2.AutoSize = true;
            this.cb_led2.Location = new System.Drawing.Point(4, 56);
            this.cb_led2.Name = "cb_led2";
            this.cb_led2.Size = new System.Drawing.Size(62, 20);
            this.cb_led2.TabIndex = 9;
            this.cb_led2.Text = "Led 2";
            this.cb_led2.UseVisualStyleBackColor = true;
            this.cb_led2.CheckedChanged += new System.EventHandler(this.cb_led2_CheckedChanged);
            // 
            // cb_led1
            // 
            this.cb_led1.AutoSize = true;
            this.cb_led1.Location = new System.Drawing.Point(4, 29);
            this.cb_led1.Name = "cb_led1";
            this.cb_led1.Size = new System.Drawing.Size(62, 20);
            this.cb_led1.TabIndex = 9;
            this.cb_led1.Text = "Led 1";
            this.cb_led1.UseVisualStyleBackColor = true;
            this.cb_led1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_led15);
            this.groupBox4.Controls.Add(this.cb_led14);
            this.groupBox4.Controls.Add(this.cb_led1);
            this.groupBox4.Controls.Add(this.cb_led2);
            this.groupBox4.Location = new System.Drawing.Point(290, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 140);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED";
            // 
            // cb_led15
            // 
            this.cb_led15.AutoSize = true;
            this.cb_led15.Location = new System.Drawing.Point(4, 108);
            this.cb_led15.Name = "cb_led15";
            this.cb_led15.Size = new System.Drawing.Size(62, 20);
            this.cb_led15.TabIndex = 11;
            this.cb_led15.Text = "Led 4";
            this.cb_led15.UseVisualStyleBackColor = true;
            this.cb_led15.CheckedChanged += new System.EventHandler(this.cb_led15_CheckedChanged);
            // 
            // cb_led14
            // 
            this.cb_led14.AutoSize = true;
            this.cb_led14.Location = new System.Drawing.Point(4, 82);
            this.cb_led14.Name = "cb_led14";
            this.cb_led14.Size = new System.Drawing.Size(62, 20);
            this.cb_led14.TabIndex = 10;
            this.cb_led14.Text = "Led 3";
            this.cb_led14.UseVisualStyleBackColor = true;
            this.cb_led14.CheckedChanged += new System.EventHandler(this.cb_led14_CheckedChanged);
            // 
            // txt_syn
            // 
            this.txt_syn.Location = new System.Drawing.Point(6, 40);
            this.txt_syn.Multiline = true;
            this.txt_syn.Name = "txt_syn";
            this.txt_syn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_syn.Size = new System.Drawing.Size(203, 171);
            this.txt_syn.TabIndex = 13;
            // 
            // Handshake
            // 
            this.Handshake.Controls.Add(this.txt_ack);
            this.Handshake.Controls.Add(this.txt_syn);
            this.Handshake.Controls.Add(this.label6);
            this.Handshake.Controls.Add(this.label5);
            this.Handshake.Location = new System.Drawing.Point(12, 251);
            this.Handshake.Name = "Handshake";
            this.Handshake.Size = new System.Drawing.Size(480, 225);
            this.Handshake.TabIndex = 14;
            this.Handshake.TabStop = false;
            this.Handshake.Text = "HANDSHAKE";
            // 
            // txt_ack
            // 
            this.txt_ack.Location = new System.Drawing.Point(242, 40);
            this.txt_ack.Multiline = true;
            this.txt_ack.Name = "txt_ack";
            this.txt_ack.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ack.Size = new System.Drawing.Size(206, 171);
            this.txt_ack.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "STM to PC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "PC to STM";
            // 
            // txt_emergency
            // 
            this.txt_emergency.ForeColor = System.Drawing.Color.Black;
            this.txt_emergency.Location = new System.Drawing.Point(6, 27);
            this.txt_emergency.Name = "txt_emergency";
            this.txt_emergency.Size = new System.Drawing.Size(184, 22);
            this.txt_emergency.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_emergency);
            this.groupBox5.Location = new System.Drawing.Point(290, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 59);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BUTTON";
            // 
            // txt_adc
            // 
            this.txt_adc.Location = new System.Drawing.Point(6, 21);
            this.txt_adc.Name = "txt_adc";
            this.txt_adc.Size = new System.Drawing.Size(184, 22);
            this.txt_adc.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_adc);
            this.groupBox1.Location = new System.Drawing.Point(290, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage";
            // 
            // txt_receive_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Handshake);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "txt_receive_data";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Handshake.ResumeLayout(false);
            this.Handshake.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox cbb_select_com;
        private System.Windows.Forms.ComboBox cbb_select_baud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_datasize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_parity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_led2;
        private System.Windows.Forms.CheckBox cb_led1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb_led15;
        private System.Windows.Forms.CheckBox cb_led14;
        private System.Windows.Forms.TextBox txt_syn;
        private System.Windows.Forms.GroupBox Handshake;
        private System.Windows.Forms.TextBox txt_ack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_emergency;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_adc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

