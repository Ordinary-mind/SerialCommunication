using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommunication
{
    public partial class SerialPortForm : Form
    {
        public SerialPortForm()
        {
            InitializeComponent();
        }

        SerialPort serialPort = new SerialPort();
        Thread th;
        private String str;
        private bool serialPortFlag = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String s in System.IO.Ports.SerialPort.GetPortNames())
            {
                txt_portList.Items.Add(s);
            }
            txt_portList.SelectedIndex = 0;
        }

        private void receiveData()
        {
            while (serialPort.IsOpen)
            {
                str = serialPort.ReadExisting();
                try
                {
                    if (str != "")
                    {
                        txt_dataRecv.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Recv=" + str + "\r\n";
                    }
                }
                catch
                {
                    MessageBox.Show("在读取信息时发生了错误！");
                }
                finally
                {
                    str = "";
                    Thread.Sleep(200);
                }
            }
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
                byte[] bytes = encoding.GetBytes(txt_dataSend.Text);
                serialPort.Write(bytes, 0, bytes.Length);
                txt_dataRecv.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Send=" + Encoding.Default.GetString(bytes) + "\r\n";
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
                serialPort.PortName = txt_portList.Text;
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Open();
                serialPortFlag = serialPort.IsOpen;
                if (serialPortFlag)
                {
                    MessageBox.Show("串口" + txt_portList.Text + "打开成功！");
                    ThreadStart threadStart = new ThreadStart(receiveData);
                    th = new Thread(threadStart);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("串口" + txt_portList.Text + "打开失败！");
                }
                
            }
            catch
            {
                MessageBox.Show("在打开端口过程中发生错误");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (th != null)
            {
                th.Abort();
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void btn_clearBuffer_Click(object sender, EventArgs e)
        {
            txt_dataRecv.Clear();
        }
    }
}
