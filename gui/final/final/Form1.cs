using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;




namespace final
{
    public partial class txt_receive_data : Form
    {
        //Frame
        //Start
        byte[] STX =new byte[] { 0X02 } ;
        

        //Command
        byte[] LED12 = { 0X19 };
        byte[] LED13 = { 0X18 };
        byte[] LED14 = { 0X17 };
        byte[] LED15 = { 0X16 };


        //End
        byte[] ETX = { 0x03 };

        

        // Khai báo 1 biến dùng cho timer, chạy cột thời gian tính bằng ms
        public txt_receive_data()
        {
            InitializeComponent();
            getAvailablePorts();
        }
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cbb_select_com.Items.AddRange(ports);
        }
        string[] baud = {  "9600", "115200" };
        string[] datasize = { "7", "8","9" };


        
        private void Form1_Load(object sender, EventArgs e)
        {

            string[] myport = SerialPort.GetPortNames();
            cbb_select_com.Items.AddRange(myport);
            cbb_select_baud.Items.AddRange(baud);
            cbb_datasize.Items.AddRange(datasize);
            cbb_parity.Items.AddRange(Enum.GetNames(typeof(Parity)));

        }

      
       
        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!serialPort1.IsOpen)
            {
                bt_connect.Text = "DISCONNECT";
                serialPort1.PortName = cbb_select_com.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbb_select_baud.Text);
                serialPort1.DataBits = Convert.ToInt32(cbb_datasize.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cbb_parity.Text);
                serialPort1.Open();
            }
            else if(serialPort1.IsOpen)
            {
                bt_connect.Text = "CONNECT";
                

                serialPort1.Close();
            }

        }


 

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led1.Checked)==true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED12);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 1: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX); // 1

                string s2 = System.Text.Encoding.UTF8.GetString(LED12); // 1

                string s3 = System.Text.Encoding.UTF8.GetString(ETX); // 1

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 1: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            
        }
        private void cb_led2_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led2.Checked) == true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED13);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 2: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED13);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 2: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
           
        }
        private void cb_led14_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led14.Checked) == true)
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED14);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 3: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {
                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED14);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 3: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
        }
        private void cb_led15_CheckedChanged(object sender, EventArgs e)
        {
            if ((cb_led15.Checked) == true)
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED15);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00001" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 4: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
            else
            {

                string s1 = System.Text.Encoding.UTF8.GetString(STX);

                string s2 = System.Text.Encoding.UTF8.GetString(LED15);

                string s3 = System.Text.Encoding.UTF8.GetString(ETX);

                string s = s1 + s2 + "00000" + s3;
                serialPort1.Write(s);

                txt_syn.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine;
                txt_syn.Text += "set Led 4: " + Environment.NewLine;
                txt_syn.Text += s + Environment.NewLine;

                txt_syn.SelectionStart = txt_syn.TextLength;
                txt_syn.ScrollToCaret();
            }
        }

       
        
        private void OnData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            String Data_In = "";
            Data_In = serialPort1.ReadExisting();
            
            if (Data_In != String.Empty)
            {
                SetText(Data_In); // Chính vì vậy phải sử dụng ủy quyền đây.Gọi delegate đã khai báo trước đó.
            }
        }

        private delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.txt_emergency.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Substring(0, 1) == "\u0002")
                {
                    txt_ack.Text += Environment.NewLine + DateTime.Now.ToString() + Environment.NewLine ;
                    this.txt_ack.Text += text;
                    txt_ack.Text += Environment.NewLine;
                    this.txt_ack.SelectionStart = txt_syn.TextLength;
                    this.txt_ack.ScrollToCaret();
                }
                else if(text.Substring(0, 1) == "\u0006")
                {
                    this.txt_emergency.Text = "ON";
                }
                else
                {
                    this.txt_adc.Text = text;
                }
            }
        }
    }
}
