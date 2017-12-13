namespace SerialCommunication
{
    partial class SerialPortForm
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
            this.txt_portList = new System.Windows.Forms.ComboBox();
            this.txt_dataSend = new System.Windows.Forms.TextBox();
            this.txt_dataRecv = new System.Windows.Forms.TextBox();
            this.lb_portList = new System.Windows.Forms.Label();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.btn_sendData = new System.Windows.Forms.Button();
            this.la_dataSend = new System.Windows.Forms.Label();
            this.lb_dataRecv = new System.Windows.Forms.Label();
            this.btn_clearBuffer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_portList
            // 
            this.txt_portList.FormattingEnabled = true;
            this.txt_portList.Location = new System.Drawing.Point(84, 27);
            this.txt_portList.Name = "txt_portList";
            this.txt_portList.Size = new System.Drawing.Size(128, 20);
            this.txt_portList.TabIndex = 0;
            // 
            // txt_dataSend
            // 
            this.txt_dataSend.Location = new System.Drawing.Point(84, 69);
            this.txt_dataSend.Name = "txt_dataSend";
            this.txt_dataSend.Size = new System.Drawing.Size(175, 21);
            this.txt_dataSend.TabIndex = 1;
            // 
            // txt_dataRecv
            // 
            this.txt_dataRecv.Location = new System.Drawing.Point(84, 109);
            this.txt_dataRecv.Multiline = true;
            this.txt_dataRecv.Name = "txt_dataRecv";
            this.txt_dataRecv.Size = new System.Drawing.Size(256, 131);
            this.txt_dataRecv.TabIndex = 2;
            // 
            // lb_portList
            // 
            this.lb_portList.AutoSize = true;
            this.lb_portList.Location = new System.Drawing.Point(21, 30);
            this.lb_portList.Name = "lb_portList";
            this.lb_portList.Size = new System.Drawing.Size(53, 12);
            this.lb_portList.TabIndex = 3;
            this.lb_portList.Text = "串口列表";
            // 
            // btn_openPort
            // 
            this.btn_openPort.Location = new System.Drawing.Point(227, 25);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(75, 23);
            this.btn_openPort.TabIndex = 4;
            this.btn_openPort.Text = "打开";
            this.btn_openPort.UseVisualStyleBackColor = true;
            this.btn_openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // btn_sendData
            // 
            this.btn_sendData.Location = new System.Drawing.Point(265, 67);
            this.btn_sendData.Name = "btn_sendData";
            this.btn_sendData.Size = new System.Drawing.Size(75, 23);
            this.btn_sendData.TabIndex = 5;
            this.btn_sendData.Text = "发送";
            this.btn_sendData.UseVisualStyleBackColor = true;
            this.btn_sendData.Click += new System.EventHandler(this.btn_sendData_Click);
            // 
            // la_dataSend
            // 
            this.la_dataSend.AutoSize = true;
            this.la_dataSend.Location = new System.Drawing.Point(23, 78);
            this.la_dataSend.Name = "la_dataSend";
            this.la_dataSend.Size = new System.Drawing.Size(53, 12);
            this.la_dataSend.TabIndex = 6;
            this.la_dataSend.Text = "发送指令";
            // 
            // lb_dataRecv
            // 
            this.lb_dataRecv.AutoSize = true;
            this.lb_dataRecv.Location = new System.Drawing.Point(23, 128);
            this.lb_dataRecv.Name = "lb_dataRecv";
            this.lb_dataRecv.Size = new System.Drawing.Size(53, 12);
            this.lb_dataRecv.TabIndex = 7;
            this.lb_dataRecv.Text = "收发记录";
            // 
            // btn_clearBuffer
            // 
            this.btn_clearBuffer.Location = new System.Drawing.Point(248, 249);
            this.btn_clearBuffer.Name = "btn_clearBuffer";
            this.btn_clearBuffer.Size = new System.Drawing.Size(92, 23);
            this.btn_clearBuffer.TabIndex = 8;
            this.btn_clearBuffer.Text = "清空收发记录";
            this.btn_clearBuffer.UseVisualStyleBackColor = true;
            this.btn_clearBuffer.Click += new System.EventHandler(this.btn_clearBuffer_Click);
            // 
            // SerialPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 297);
            this.Controls.Add(this.btn_clearBuffer);
            this.Controls.Add(this.lb_dataRecv);
            this.Controls.Add(this.la_dataSend);
            this.Controls.Add(this.btn_sendData);
            this.Controls.Add(this.btn_openPort);
            this.Controls.Add(this.lb_portList);
            this.Controls.Add(this.txt_dataRecv);
            this.Controls.Add(this.txt_dataSend);
            this.Controls.Add(this.txt_portList);
            this.Name = "SerialPortForm";
            this.Text = "串口通信模拟";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_portList;
        private System.Windows.Forms.TextBox txt_dataSend;
        private System.Windows.Forms.TextBox txt_dataRecv;
        private System.Windows.Forms.Label lb_portList;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Button btn_sendData;
        private System.Windows.Forms.Label la_dataSend;
        private System.Windows.Forms.Label lb_dataRecv;
        private System.Windows.Forms.Button btn_clearBuffer;
    }
}

