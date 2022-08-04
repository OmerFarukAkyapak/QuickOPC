namespace test_qopc
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
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint1 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            this.txtCurData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblOnClick = new System.Windows.Forms.Label();
            this.txtOnData = new System.Windows.Forms.TextBox();
            this.lblCurrentTimer = new System.Windows.Forms.Label();
            this.lblSubscribeOn = new System.Windows.Forms.Label();
            this.numericInterval = new System.Windows.Forms.NumericUpDown();
            this.lblInterval = new System.Windows.Forms.Label();
            this.pnlSub = new System.Windows.Forms.Panel();
            this.txtSubData = new System.Windows.Forms.TextBox();
            this.txtSubStat = new System.Windows.Forms.TextBox();
            this.txtSubServer = new System.Windows.Forms.TextBox();
            this.txtSubSource = new System.Windows.Forms.TextBox();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.txtCurStat = new System.Windows.Forms.TextBox();
            this.txtCurServer = new System.Windows.Forms.TextBox();
            this.txtCurSource = new System.Windows.Forms.TextBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNode = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblCulture = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pointBinding1 = new OpcLabs.BaseLib.LiveBinding.PointBinding(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).BeginInit();
            this.pnlSub.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurData
            // 
            this.txtCurData.BackColor = System.Drawing.Color.Silver;
            this.txtCurData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurData.ForeColor = System.Drawing.Color.Red;
            this.txtCurData.HideSelection = false;
            this.txtCurData.Location = new System.Drawing.Point(40, 12);
            this.txtCurData.Multiline = true;
            this.txtCurData.Name = "txtCurData";
            this.txtCurData.ReadOnly = true;
            this.txtCurData.Size = new System.Drawing.Size(200, 30);
            this.txtCurData.TabIndex = 25;
            this.txtCurData.Text = "Data Value";
            this.txtCurData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.lblOnClick);
            this.panel1.Controls.Add(this.txtOnData);
            this.panel1.Controls.Add(this.lblCurrentTimer);
            this.panel1.Controls.Add(this.lblSubscribeOn);
            this.panel1.Controls.Add(this.numericInterval);
            this.panel1.Controls.Add(this.lblInterval);
            this.panel1.Controls.Add(this.pnlSub);
            this.panel1.Controls.Add(this.pnlTimer);
            this.panel1.Controls.Add(this.pnlInfo);
            this.panel1.Controls.Add(this.lblCulture);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnRead);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 416);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(612, 198);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 43);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(612, 262);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(109, 43);
            this.btnStop.TabIndex = 47;
            this.btnStop.Text = "Durdur";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblOnClick
            // 
            this.lblOnClick.AutoSize = true;
            this.lblOnClick.BackColor = System.Drawing.Color.LightGray;
            this.lblOnClick.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblOnClick.Location = new System.Drawing.Point(564, 350);
            this.lblOnClick.Name = "lblOnClick";
            this.lblOnClick.Size = new System.Drawing.Size(63, 17);
            this.lblOnClick.TabIndex = 46;
            this.lblOnClick.Text = "On Click";
            // 
            // txtOnData
            // 
            this.txtOnData.BackColor = System.Drawing.Color.Silver;
            this.txtOnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtOnData.ForeColor = System.Drawing.Color.Red;
            this.txtOnData.HideSelection = false;
            this.txtOnData.Location = new System.Drawing.Point(501, 370);
            this.txtOnData.Multiline = true;
            this.txtOnData.Name = "txtOnData";
            this.txtOnData.ReadOnly = true;
            this.txtOnData.Size = new System.Drawing.Size(200, 30);
            this.txtOnData.TabIndex = 45;
            this.txtOnData.Text = "#Data Value";
            this.txtOnData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentTimer
            // 
            this.lblCurrentTimer.AutoSize = true;
            this.lblCurrentTimer.BackColor = System.Drawing.Color.LightGray;
            this.lblCurrentTimer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentTimer.Location = new System.Drawing.Point(83, 124);
            this.lblCurrentTimer.Name = "lblCurrentTimer";
            this.lblCurrentTimer.Size = new System.Drawing.Size(176, 17);
            this.lblCurrentTimer.TabIndex = 44;
            this.lblCurrentTimer.Text = "Current Time with Timer";
            // 
            // lblSubscribeOn
            // 
            this.lblSubscribeOn.AutoSize = true;
            this.lblSubscribeOn.BackColor = System.Drawing.Color.LightGray;
            this.lblSubscribeOn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubscribeOn.Location = new System.Drawing.Point(1023, 124);
            this.lblSubscribeOn.Name = "lblSubscribeOn";
            this.lblSubscribeOn.Size = new System.Drawing.Size(99, 17);
            this.lblSubscribeOn.TabIndex = 43;
            this.lblSubscribeOn.Text = "Subscribe On";
            // 
            // numericInterval
            // 
            this.numericInterval.Font = new System.Drawing.Font("Tahoma", 10F);
            this.numericInterval.Location = new System.Drawing.Point(661, 154);
            this.numericInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericInterval.Name = "numericInterval";
            this.numericInterval.Size = new System.Drawing.Size(60, 24);
            this.numericInterval.TabIndex = 42;
            this.numericInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.BackColor = System.Drawing.Color.LightGray;
            this.lblInterval.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblInterval.Location = new System.Drawing.Point(468, 156);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(171, 17);
            this.lblInterval.TabIndex = 41;
            this.lblInterval.Text = "Sampling Interval (ms):";
            // 
            // pnlSub
            // 
            this.pnlSub.Controls.Add(this.txtSubData);
            this.pnlSub.Controls.Add(this.txtSubStat);
            this.pnlSub.Controls.Add(this.txtSubServer);
            this.pnlSub.Controls.Add(this.txtSubSource);
            this.pnlSub.Location = new System.Drawing.Point(849, 144);
            this.pnlSub.Name = "pnlSub";
            this.pnlSub.Size = new System.Drawing.Size(273, 223);
            this.pnlSub.TabIndex = 38;
            // 
            // txtSubData
            // 
            this.txtSubData.BackColor = System.Drawing.Color.Silver;
            this.txtSubData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubData.ForeColor = System.Drawing.Color.Red;
            this.txtSubData.HideSelection = false;
            this.txtSubData.Location = new System.Drawing.Point(34, 18);
            this.txtSubData.Multiline = true;
            this.txtSubData.Name = "txtSubData";
            this.txtSubData.ReadOnly = true;
            this.txtSubData.Size = new System.Drawing.Size(200, 30);
            this.txtSubData.TabIndex = 29;
            this.txtSubData.Text = "$Data Value";
            this.txtSubData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubStat
            // 
            this.txtSubStat.BackColor = System.Drawing.Color.Silver;
            this.txtSubStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubStat.ForeColor = System.Drawing.Color.Red;
            this.txtSubStat.HideSelection = false;
            this.txtSubStat.Location = new System.Drawing.Point(36, 67);
            this.txtSubStat.Multiline = true;
            this.txtSubStat.Name = "txtSubStat";
            this.txtSubStat.ReadOnly = true;
            this.txtSubStat.Size = new System.Drawing.Size(200, 30);
            this.txtSubStat.TabIndex = 30;
            this.txtSubStat.Text = "$Status";
            this.txtSubStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubServer
            // 
            this.txtSubServer.BackColor = System.Drawing.Color.Silver;
            this.txtSubServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubServer.ForeColor = System.Drawing.Color.Red;
            this.txtSubServer.HideSelection = false;
            this.txtSubServer.Location = new System.Drawing.Point(34, 118);
            this.txtSubServer.Multiline = true;
            this.txtSubServer.Name = "txtSubServer";
            this.txtSubServer.ReadOnly = true;
            this.txtSubServer.Size = new System.Drawing.Size(200, 30);
            this.txtSubServer.TabIndex = 31;
            this.txtSubServer.Text = "$ServerTimestamp";
            this.txtSubServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubSource
            // 
            this.txtSubSource.BackColor = System.Drawing.Color.Silver;
            this.txtSubSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSubSource.ForeColor = System.Drawing.Color.Red;
            this.txtSubSource.HideSelection = false;
            this.txtSubSource.Location = new System.Drawing.Point(34, 167);
            this.txtSubSource.Multiline = true;
            this.txtSubSource.Name = "txtSubSource";
            this.txtSubSource.ReadOnly = true;
            this.txtSubSource.Size = new System.Drawing.Size(200, 30);
            this.txtSubSource.TabIndex = 33;
            this.txtSubSource.Text = "$SourceTimestamp";
            this.txtSubSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTimer
            // 
            this.pnlTimer.Controls.Add(this.txtCurData);
            this.pnlTimer.Controls.Add(this.txtCurStat);
            this.pnlTimer.Controls.Add(this.txtCurServer);
            this.pnlTimer.Controls.Add(this.txtCurSource);
            this.pnlTimer.Location = new System.Drawing.Point(86, 144);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(273, 223);
            this.pnlTimer.TabIndex = 37;
            // 
            // txtCurStat
            // 
            this.txtCurStat.BackColor = System.Drawing.Color.Silver;
            this.txtCurStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurStat.ForeColor = System.Drawing.Color.Red;
            this.txtCurStat.HideSelection = false;
            this.txtCurStat.Location = new System.Drawing.Point(40, 61);
            this.txtCurStat.Multiline = true;
            this.txtCurStat.Name = "txtCurStat";
            this.txtCurStat.ReadOnly = true;
            this.txtCurStat.Size = new System.Drawing.Size(200, 30);
            this.txtCurStat.TabIndex = 26;
            this.txtCurStat.Text = "Status";
            this.txtCurStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurServer
            // 
            this.txtCurServer.BackColor = System.Drawing.Color.Silver;
            this.txtCurServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurServer.ForeColor = System.Drawing.Color.Red;
            this.txtCurServer.HideSelection = false;
            this.txtCurServer.Location = new System.Drawing.Point(40, 112);
            this.txtCurServer.Multiline = true;
            this.txtCurServer.Name = "txtCurServer";
            this.txtCurServer.ReadOnly = true;
            this.txtCurServer.Size = new System.Drawing.Size(200, 30);
            this.txtCurServer.TabIndex = 27;
            this.txtCurServer.Text = "ServerTimestamp";
            this.txtCurServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurSource
            // 
            this.txtCurSource.BackColor = System.Drawing.Color.Silver;
            this.txtCurSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCurSource.ForeColor = System.Drawing.Color.Red;
            this.txtCurSource.HideSelection = false;
            this.txtCurSource.Location = new System.Drawing.Point(40, 161);
            this.txtCurSource.Multiline = true;
            this.txtCurSource.Name = "txtCurSource";
            this.txtCurSource.ReadOnly = true;
            this.txtCurSource.Size = new System.Drawing.Size(200, 30);
            this.txtCurSource.TabIndex = 32;
            this.txtCurSource.Text = "SourceTimestamp";
            this.txtCurSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.lblNode);
            this.pnlInfo.Controls.Add(this.lblServer);
            this.pnlInfo.Location = new System.Drawing.Point(363, 64);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(483, 65);
            this.pnlInfo.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(64, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "Node:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Server:";
            // 
            // lblNode
            // 
            this.lblNode.AutoSize = true;
            this.lblNode.BackColor = System.Drawing.Color.LightGray;
            this.lblNode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblNode.Location = new System.Drawing.Point(114, 38);
            this.lblNode.Name = "lblNode";
            this.lblNode.Size = new System.Drawing.Size(290, 17);
            this.lblNode.TabIndex = 35;
            this.lblNode.Text = "nsu=http://test.org/UA/Data/;i=10853";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.BackColor = System.Drawing.Color.LightGray;
            this.lblServer.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblServer.Location = new System.Drawing.Point(73, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(389, 17);
            this.lblServer.TabIndex = 34;
            this.lblServer.Text = "http://opcua.demo-this.com:51211/UA/SampleServer";
            // 
            // lblCulture
            // 
            this.lblCulture.AutoSize = true;
            this.lblCulture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCulture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCulture.Location = new System.Drawing.Point(21, 21);
            this.lblCulture.Name = "lblCulture";
            this.lblCulture.Size = new System.Drawing.Size(15, 16);
            this.lblCulture.TabIndex = 28;
            this.lblCulture.Text = "0";
            this.lblCulture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(471, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(109, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Sıfırla";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnRead.Location = new System.Drawing.Point(471, 198);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(109, 43);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Veri Al";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(490, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "QOPS SUBSCRIBE";
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyUAClient1_DataChangeNotification);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pointBinding1
            // 
            this.pointBinding1.ArgumentsPath = "Value";
            daItemPoint1.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("Demo.Ramp", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Demo",
                "Ramp"}));
            daItemPoint1.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding1.Point = daItemPoint1;
            this.pointBinding1.ValueTarget.TargetComponent = this.txtCurData;
            this.pointBinding1.ValueTarget.TargetPath = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1214, 440);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "QOPC TEST -Ömer Faruk Akyapak";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInterval)).EndInit();
            this.pnlSub.ResumeLayout(false);
            this.pnlSub.PerformLayout();
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCurData;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding1;
        private System.Windows.Forms.Panel panel1;
        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCurStat;
        private System.Windows.Forms.TextBox txtCurServer;
        private System.Windows.Forms.Label lblCulture;
        private System.Windows.Forms.TextBox txtSubServer;
        private System.Windows.Forms.TextBox txtSubStat;
        private System.Windows.Forms.TextBox txtSubData;
        private System.Windows.Forms.TextBox txtSubSource;
        private System.Windows.Forms.TextBox txtCurSource;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblNode;
        private System.Windows.Forms.Panel pnlSub;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentTimer;
        private System.Windows.Forms.Label lblSubscribeOn;
        private System.Windows.Forms.NumericUpDown numericInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtOnData;
        private System.Windows.Forms.Label lblOnClick;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

