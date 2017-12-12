namespace SerialCommunication
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
            this.portList = new System.Windows.Forms.ComboBox();
            this.dataSend = new System.Windows.Forms.TextBox();
            this.dataRecv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openPort = new System.Windows.Forms.Button();
            this.btn_sendData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(84, 27);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(128, 20);
            this.portList.TabIndex = 0;
            // 
            // dataSend
            // 
            this.dataSend.Location = new System.Drawing.Point(84, 69);
            this.dataSend.Name = "dataSend";
            this.dataSend.Size = new System.Drawing.Size(175, 21);
            this.dataSend.TabIndex = 1;
            // 
            // dataRecv
            // 
            this.dataRecv.Location = new System.Drawing.Point(84, 109);
            this.dataRecv.Multiline = true;
            this.dataRecv.Name = "dataRecv";
            this.dataRecv.Size = new System.Drawing.Size(256, 131);
            this.dataRecv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口列表";
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(227, 25);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(75, 23);
            this.openPort.TabIndex = 4;
            this.openPort.Text = "打开";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "发送指令";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "收发记录";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_sendData);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataRecv);
            this.Controls.Add(this.dataSend);
            this.Controls.Add(this.portList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.TextBox dataSend;
        private System.Windows.Forms.TextBox dataRecv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openPort;
        private System.Windows.Forms.Button btn_sendData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer;
    }
}

