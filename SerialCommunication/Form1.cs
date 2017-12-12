using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort serialPort = new SerialPort();
        private long SendCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
            {
                portList.Items.Add(s);
            }
            portList.SelectedIndex = 0;
        }

        private void btn_sendData_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开,无法发送数据!");
                return;
            }
            try
            {
                Encoding encoding = Encoding.GetEncoding("GB2312");
                byte[] bytes = encoding.GetBytes(dataSend.Text);
                SendCount += (long)bytes.Length;
                serialPort.Write(bytes, 0, bytes.Length);
                dataRecv.Text += "发：" + Encoding.Default.GetString(bytes) + "\r\n";
            }
            catch
            {
                MessageBox.Show("发送失败!");
            }
        }

        private void openPort_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Encoding = Encoding.GetEncoding("GB18030");
                serialPort.PortName = portList.Text;
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Open();
                MessageBox.Show("串口" + portList.Text + "打开成功！");
            }
            catch
            {
                MessageBox.Show("串口" + portList.Text + "打开失败！");
            }
        }

        private void dataRecv_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                String str = serialPort.ReadExisting();
                try
                {
                    if (str != "")
                    {
                        dataRecv.Text += "收：" + str + "\r\n";
                    }
                }
                catch
                {
                    MessageBox.Show("在读取信息时发生了错误！");
                }
                finally
                {
                    str = "";
                }
            }
        }
    }
}
