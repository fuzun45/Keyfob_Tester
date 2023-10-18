using System.Windows.Forms;

namespace Keyfob_Tester
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage_FunctionControl = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_EvalBoardMessages = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_StopPolling = new System.Windows.Forms.Button();
            this.button_StopRKE = new System.Windows.Forms.Button();
            this.button_StartRKE = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_StartPolling = new System.Windows.Forms.Button();
            this.button_GetKeyList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ResetDeviceEvalBoard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Connections = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Status2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Disconnect2 = new System.Windows.Forms.Button();
            this.button_Connect2 = new System.Windows.Forms.Button();
            this.label_ConnectionName2 = new System.Windows.Forms.Label();
            this.comboBox_BaudrateEvalBoard = new System.Windows.Forms.ComboBox();
            this.comboBox_COMPortEvalBoard = new System.Windows.Forms.ComboBox();
            this.label_Baudrate2 = new System.Windows.Forms.Label();
            this.label_COMPort2 = new System.Windows.Forms.Label();
            this.tab_Program = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_StopImmobilizer = new System.Windows.Forms.Button();
            this.button_StartImmobilizer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_FunctionControl.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox11.SuspendLayout();
            this.tabPage_Connections.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_Program.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_FunctionControl
            // 
            this.tabPage_FunctionControl.Controls.Add(this.groupBox7);
            this.tabPage_FunctionControl.Controls.Add(this.groupBox11);
            this.tabPage_FunctionControl.Location = new System.Drawing.Point(4, 22);
            this.tabPage_FunctionControl.Name = "tabPage_FunctionControl";
            this.tabPage_FunctionControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FunctionControl.Size = new System.Drawing.Size(1349, 563);
            this.tabPage_FunctionControl.TabIndex = 1;
            this.tabPage_FunctionControl.Text = "Function Control";
            this.tabPage_FunctionControl.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chart1);
            this.groupBox7.Controls.Add(this.textBox_EvalBoardMessages);
            this.groupBox7.Location = new System.Drawing.Point(387, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(955, 547);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 319);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CH1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "CH2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "CH3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(949, 222);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // textBox_EvalBoardMessages
            // 
            this.textBox_EvalBoardMessages.Location = new System.Drawing.Point(6, 13);
            this.textBox_EvalBoardMessages.Multiline = true;
            this.textBox_EvalBoardMessages.Name = "textBox_EvalBoardMessages";
            this.textBox_EvalBoardMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_EvalBoardMessages.Size = new System.Drawing.Size(949, 300);
            this.textBox_EvalBoardMessages.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button2);
            this.groupBox11.Controls.Add(this.button_StopImmobilizer);
            this.groupBox11.Controls.Add(this.button_StartImmobilizer);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.button_Clear);
            this.groupBox11.Controls.Add(this.button_Save);
            this.groupBox11.Controls.Add(this.label1);
            this.groupBox11.Controls.Add(this.comboBox1);
            this.groupBox11.Controls.Add(this.button_StopPolling);
            this.groupBox11.Controls.Add(this.button_StopRKE);
            this.groupBox11.Controls.Add(this.button_StartRKE);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.button_StartPolling);
            this.groupBox11.Controls.Add(this.button_GetKeyList);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.button_ResetDeviceEvalBoard);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Location = new System.Drawing.Point(3, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(378, 547);
            this.groupBox11.TabIndex = 22;
            this.groupBox11.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Log Messages - Chart";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(12, 435);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 24;
            this.button_Clear.Text = "Temizle";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(93, 435);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 23;
            this.button_Save.Text = "Kaydet";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Key";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // button_StopPolling
            // 
            this.button_StopPolling.Location = new System.Drawing.Point(273, 193);
            this.button_StopPolling.Name = "button_StopPolling";
            this.button_StopPolling.Size = new System.Drawing.Size(88, 34);
            this.button_StopPolling.TabIndex = 12;
            this.button_StopPolling.Text = "Stop";
            this.button_StopPolling.UseVisualStyleBackColor = true;
            this.button_StopPolling.Click += new System.EventHandler(this.button_StopPolling_Click);
            // 
            // button_StopRKE
            // 
            this.button_StopRKE.Location = new System.Drawing.Point(138, 279);
            this.button_StopRKE.Name = "button_StopRKE";
            this.button_StopRKE.Size = new System.Drawing.Size(88, 34);
            this.button_StopRKE.TabIndex = 11;
            this.button_StopRKE.Text = "Stop";
            this.button_StopRKE.UseVisualStyleBackColor = true;
            this.button_StopRKE.Click += new System.EventHandler(this.button_StopRKE_Click);
            // 
            // button_StartRKE
            // 
            this.button_StartRKE.Location = new System.Drawing.Point(12, 279);
            this.button_StartRKE.Name = "button_StartRKE";
            this.button_StartRKE.Size = new System.Drawing.Size(88, 34);
            this.button_StartRKE.TabIndex = 10;
            this.button_StartRKE.Text = "Start RKE";
            this.button_StartRKE.UseVisualStyleBackColor = true;
            this.button_StartRKE.Click += new System.EventHandler(this.button_StartRKE_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "RKE Function";
            // 
            // button_StartPolling
            // 
            this.button_StartPolling.Location = new System.Drawing.Point(11, 193);
            this.button_StartPolling.Name = "button_StartPolling";
            this.button_StartPolling.Size = new System.Drawing.Size(88, 34);
            this.button_StartPolling.TabIndex = 8;
            this.button_StartPolling.Text = "Start Polling RSSI";
            this.button_StartPolling.UseVisualStyleBackColor = true;
            this.button_StartPolling.Click += new System.EventHandler(this.button_StartPolling_Click);
            // 
            // button_GetKeyList
            // 
            this.button_GetKeyList.Location = new System.Drawing.Point(12, 128);
            this.button_GetKeyList.Name = "button_GetKeyList";
            this.button_GetKeyList.Size = new System.Drawing.Size(88, 34);
            this.button_GetKeyList.TabIndex = 7;
            this.button_GetKeyList.Text = "Get Key List";
            this.button_GetKeyList.UseVisualStyleBackColor = true;
            this.button_GetKeyList.Click += new System.EventHandler(this.button_GetKeyList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "PKE Function";
            // 
            // button_ResetDeviceEvalBoard
            // 
            this.button_ResetDeviceEvalBoard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ResetDeviceEvalBoard.Location = new System.Drawing.Point(11, 49);
            this.button_ResetDeviceEvalBoard.Name = "button_ResetDeviceEvalBoard";
            this.button_ResetDeviceEvalBoard.Size = new System.Drawing.Size(88, 34);
            this.button_ResetDeviceEvalBoard.TabIndex = 4;
            this.button_ResetDeviceEvalBoard.Text = "Reset Device";
            this.button_ResetDeviceEvalBoard.UseVisualStyleBackColor = true;
            this.button_ResetDeviceEvalBoard.Click += new System.EventHandler(this.button_ResetDeviceEvalBoard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "EVAL Board Control";
            // 
            // tabPage_Connections
            // 
            this.tabPage_Connections.Controls.Add(this.groupBox2);
            this.tabPage_Connections.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Connections.Name = "tabPage_Connections";
            this.tabPage_Connections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connections.Size = new System.Drawing.Size(1349, 563);
            this.tabPage_Connections.TabIndex = 0;
            this.tabPage_Connections.Text = "Bağlantılar";
            this.tabPage_Connections.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Status2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button_Disconnect2);
            this.groupBox2.Controls.Add(this.button_Connect2);
            this.groupBox2.Controls.Add(this.label_ConnectionName2);
            this.groupBox2.Controls.Add(this.comboBox_BaudrateEvalBoard);
            this.groupBox2.Controls.Add(this.comboBox_COMPortEvalBoard);
            this.groupBox2.Controls.Add(this.label_Baudrate2);
            this.groupBox2.Controls.Add(this.label_COMPort2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 177);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label_Status2
            // 
            this.label_Status2.AutoSize = true;
            this.label_Status2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status2.Location = new System.Drawing.Point(70, 103);
            this.label_Status2.Name = "label_Status2";
            this.label_Status2.Size = new System.Drawing.Size(109, 16);
            this.label_Status2.TabIndex = 21;
            this.label_Status2.Text = "Not Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status: ";
            // 
            // button_Disconnect2
            // 
            this.button_Disconnect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect2.Location = new System.Drawing.Point(417, 127);
            this.button_Disconnect2.Name = "button_Disconnect2";
            this.button_Disconnect2.Size = new System.Drawing.Size(94, 34);
            this.button_Disconnect2.TabIndex = 19;
            this.button_Disconnect2.Text = "Disconnect";
            this.button_Disconnect2.UseVisualStyleBackColor = true;
            this.button_Disconnect2.Click += new System.EventHandler(this.button_Disconnect2_Click);
            // 
            // button_Connect2
            // 
            this.button_Connect2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect2.Location = new System.Drawing.Point(296, 127);
            this.button_Connect2.Name = "button_Connect2";
            this.button_Connect2.Size = new System.Drawing.Size(94, 34);
            this.button_Connect2.TabIndex = 18;
            this.button_Connect2.Text = "Connect";
            this.button_Connect2.UseVisualStyleBackColor = true;
            this.button_Connect2.Click += new System.EventHandler(this.button_Connect2_Click);
            // 
            // label_ConnectionName2
            // 
            this.label_ConnectionName2.AutoSize = true;
            this.label_ConnectionName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConnectionName2.Location = new System.Drawing.Point(6, 14);
            this.label_ConnectionName2.Name = "label_ConnectionName2";
            this.label_ConnectionName2.Size = new System.Drawing.Size(96, 20);
            this.label_ConnectionName2.TabIndex = 14;
            this.label_ConnectionName2.Text = "Eval Board";
            // 
            // comboBox_BaudrateEvalBoard
            // 
            this.comboBox_BaudrateEvalBoard.FormattingEnabled = true;
            this.comboBox_BaudrateEvalBoard.Location = new System.Drawing.Point(70, 70);
            this.comboBox_BaudrateEvalBoard.Name = "comboBox_BaudrateEvalBoard";
            this.comboBox_BaudrateEvalBoard.Size = new System.Drawing.Size(442, 21);
            this.comboBox_BaudrateEvalBoard.TabIndex = 13;
            // 
            // comboBox_COMPortEvalBoard
            // 
            this.comboBox_COMPortEvalBoard.FormattingEnabled = true;
            this.comboBox_COMPortEvalBoard.Location = new System.Drawing.Point(70, 35);
            this.comboBox_COMPortEvalBoard.Name = "comboBox_COMPortEvalBoard";
            this.comboBox_COMPortEvalBoard.Size = new System.Drawing.Size(442, 21);
            this.comboBox_COMPortEvalBoard.TabIndex = 12;
            // 
            // label_Baudrate2
            // 
            this.label_Baudrate2.AutoSize = true;
            this.label_Baudrate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Baudrate2.Location = new System.Drawing.Point(7, 73);
            this.label_Baudrate2.Name = "label_Baudrate2";
            this.label_Baudrate2.Size = new System.Drawing.Size(62, 16);
            this.label_Baudrate2.TabIndex = 11;
            this.label_Baudrate2.Text = "Baudrate";
            // 
            // label_COMPort2
            // 
            this.label_COMPort2.AutoSize = true;
            this.label_COMPort2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPort2.Location = new System.Drawing.Point(7, 38);
            this.label_COMPort2.Name = "label_COMPort2";
            this.label_COMPort2.Size = new System.Drawing.Size(64, 16);
            this.label_COMPort2.TabIndex = 10;
            this.label_COMPort2.Text = "COM Port";
            // 
            // tab_Program
            // 
            this.tab_Program.Controls.Add(this.tabPage_Connections);
            this.tab_Program.Controls.Add(this.tabPage_FunctionControl);
            this.tab_Program.Cursor = System.Windows.Forms.Cursors.Default;
            this.tab_Program.Location = new System.Drawing.Point(7, 4);
            this.tab_Program.Name = "tab_Program";
            this.tab_Program.SelectedIndex = 0;
            this.tab_Program.Size = new System.Drawing.Size(1357, 589);
            this.tab_Program.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(250, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 34);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(250, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 31;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_StopImmobilizer
            // 
            this.button_StopImmobilizer.Location = new System.Drawing.Point(137, 353);
            this.button_StopImmobilizer.Name = "button_StopImmobilizer";
            this.button_StopImmobilizer.Size = new System.Drawing.Size(88, 34);
            this.button_StopImmobilizer.TabIndex = 30;
            this.button_StopImmobilizer.Text = "Stop";
            this.button_StopImmobilizer.UseVisualStyleBackColor = true;
            // 
            // button_StartImmobilizer
            // 
            this.button_StartImmobilizer.Location = new System.Drawing.Point(11, 353);
            this.button_StartImmobilizer.Name = "button_StartImmobilizer";
            this.button_StartImmobilizer.Size = new System.Drawing.Size(88, 34);
            this.button_StartImmobilizer.TabIndex = 29;
            this.button_StartImmobilizer.Text = "Start Immobilizer ";
            this.button_StartImmobilizer.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Immboilizer Function";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 614);
            this.Controls.Add(this.tab_Program);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ford Keyfob Tester V0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage_FunctionControl.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage_Connections.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_Program.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage_FunctionControl;
        private GroupBox groupBox7;
        private TextBox textBox_EvalBoardMessages;
        private GroupBox groupBox11;
        private Button button_Clear;
        private Button button_Save;
        private Label label1;
        private ComboBox comboBox1;
        private Button button_StopPolling;
        private Button button_StopRKE;
        private Button button_StartRKE;
        private Label label10;
        private Button button_StartPolling;
        private Button button_GetKeyList;
        private Label label6;
        private Button button_ResetDeviceEvalBoard;
        private Label label5;
        private TabPage tabPage_Connections;
        private GroupBox groupBox2;
        private Label label_Status2;
        private Label label2;
        private Button button_Disconnect2;
        private Button button_Connect2;
        private Label label_ConnectionName2;
        private ComboBox comboBox_BaudrateEvalBoard;
        private ComboBox comboBox_COMPortEvalBoard;
        private Label label_Baudrate2;
        private Label label_COMPort2;
        private TabControl tab_Program;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button_StopImmobilizer;
        private Button button_StartImmobilizer;
        private Label label7;
    }
}

