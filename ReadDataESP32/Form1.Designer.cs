namespace ReadDataESP32
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFirebase = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBeaconList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrtalama = new System.Windows.Forms.Button();
            this.lblRSSI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port :";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(101, 13);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(245, 30);
            this.cmbPort.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(308, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(38, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(308, 45);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(38, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(308, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFirebase
            // 
            this.btnFirebase.Location = new System.Drawing.Point(38, 289);
            this.btnFirebase.Name = "btnFirebase";
            this.btnFirebase.Size = new System.Drawing.Size(308, 45);
            this.btnFirebase.TabIndex = 5;
            this.btnFirebase.Text = "Send Firebase";
            this.btnFirebase.UseVisualStyleBackColor = true;
            this.btnFirebase.Click += new System.EventHandler(this.btnFirebase_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(390, 41);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPort.Size = new System.Drawing.Size(315, 550);
            this.txtPort.TabIndex = 6;
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 22;
            this.lbData.Location = new System.Drawing.Point(38, 521);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(80, 70);
            this.lbData.TabIndex = 7;
            this.lbData.Visible = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serial Port Screen";
            // 
            // cmbBeaconList
            // 
            this.cmbBeaconList.FormattingEnabled = true;
            this.cmbBeaconList.Items.AddRange(new object[] {
            "Beacon1",
            "Beacon2",
            "Beacon3"});
            this.cmbBeaconList.Location = new System.Drawing.Point(101, 49);
            this.cmbBeaconList.Name = "cmbBeaconList";
            this.cmbBeaconList.Size = new System.Drawing.Size(245, 30);
            this.cmbBeaconList.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Beacon :";
            // 
            // btnOrtalama
            // 
            this.btnOrtalama.Location = new System.Drawing.Point(38, 238);
            this.btnOrtalama.Name = "btnOrtalama";
            this.btnOrtalama.Size = new System.Drawing.Size(308, 45);
            this.btnOrtalama.TabIndex = 12;
            this.btnOrtalama.Text = "Create Average RSSI Value";
            this.btnOrtalama.UseVisualStyleBackColor = true;
            this.btnOrtalama.Click += new System.EventHandler(this.btnOrtalama_Click);
            // 
            // lblRSSI
            // 
            this.lblRSSI.AutoSize = true;
            this.lblRSSI.ForeColor = System.Drawing.Color.White;
            this.lblRSSI.Location = new System.Drawing.Point(253, 569);
            this.lblRSSI.Name = "lblRSSI";
            this.lblRSSI.Size = new System.Drawing.Size(21, 22);
            this.lblRSSI.TabIndex = 13;
            this.lblRSSI.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(725, 607);
            this.Controls.Add(this.lblRSSI);
            this.Controls.Add(this.btnOrtalama);
            this.Controls.Add(this.cmbBeaconList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.btnFirebase);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFirebase;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ListBox lbData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBeaconList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrtalama;
        private System.Windows.Forms.Label lblRSSI;
    }
}

