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
            this.tab_Program = new System.Windows.Forms.TabControl();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Status1 = new System.Windows.Forms.Label();
            this.label_ConnectionStatus1 = new System.Windows.Forms.Label();
            this.button_Disconnect1 = new System.Windows.Forms.Button();
            this.button_Connect1 = new System.Windows.Forms.Button();
            this.label_ConnectionName = new System.Windows.Forms.Label();
            this.comboBox_BaudrateArduino = new System.Windows.Forms.ComboBox();
            this.comboBox_COMPortArduino = new System.Windows.Forms.ComboBox();
            this.label_Baudrate1 = new System.Windows.Forms.Label();
            this.label_COMPort1 = new System.Windows.Forms.Label();
            this.tabPage_FunctionControl = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_EvalBoardMessages = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_ArduinoMessages = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_StopPolling = new System.Windows.Forms.Button();
            this.button_StopImmobilizer = new System.Windows.Forms.Button();
            this.button_StartImmobilizer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_StartPolling = new System.Windows.Forms.Button();
            this.button_GetKeyList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_ResetDeviceEvalBoard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button_ResetDeviceArduino = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_PSActivation = new System.Windows.Forms.Button();
            this.button_UHFTxActivation = new System.Windows.Forms.Button();
            this.button_UHFTxActivated = new System.Windows.Forms.Button();
            this.button_Standby = new System.Windows.Forms.Button();
            this.button_ImmobilizerActive = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage_Test = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_GetKeyListTest = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBox_TestMessages = new System.Windows.Forms.TextBox();
            this.buttonStopTest = new System.Windows.Forms.Button();
            this.button_StartTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tab_Program.SuspendLayout();
            this.tabPage_Connections.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_FunctionControl.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_Test.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Program
            // 
            this.tab_Program.Controls.Add(this.tabPage_Connections);
            this.tab_Program.Controls.Add(this.tabPage_FunctionControl);
            this.tab_Program.Controls.Add(this.tabPage_Test);
            this.tab_Program.Location = new System.Drawing.Point(12, 12);
            this.tab_Program.Name = "tab_Program";
            this.tab_Program.SelectedIndex = 0;
            this.tab_Program.Size = new System.Drawing.Size(888, 426);
            this.tab_Program.TabIndex = 3;
            // 
            // tabPage_Connections
            // 
            this.tabPage_Connections.Controls.Add(this.groupBox2);
            this.tabPage_Connections.Controls.Add(this.groupBox1);
            this.tabPage_Connections.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Connections.Name = "tabPage_Connections";
            this.tabPage_Connections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connections.Size = new System.Drawing.Size(880, 400);
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
            this.groupBox2.Location = new System.Drawing.Point(327, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 177);
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
            this.button_Disconnect2.Location = new System.Drawing.Point(167, 126);
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
            this.button_Connect2.Location = new System.Drawing.Point(10, 126);
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
            this.comboBox_BaudrateEvalBoard.Size = new System.Drawing.Size(200, 21);
            this.comboBox_BaudrateEvalBoard.TabIndex = 13;
            // 
            // comboBox_COMPortEvalBoard
            // 
            this.comboBox_COMPortEvalBoard.FormattingEnabled = true;
            this.comboBox_COMPortEvalBoard.Location = new System.Drawing.Point(70, 35);
            this.comboBox_COMPortEvalBoard.Name = "comboBox_COMPortEvalBoard";
            this.comboBox_COMPortEvalBoard.Size = new System.Drawing.Size(200, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Status1);
            this.groupBox1.Controls.Add(this.label_ConnectionStatus1);
            this.groupBox1.Controls.Add(this.button_Disconnect1);
            this.groupBox1.Controls.Add(this.button_Connect1);
            this.groupBox1.Controls.Add(this.label_ConnectionName);
            this.groupBox1.Controls.Add(this.comboBox_BaudrateArduino);
            this.groupBox1.Controls.Add(this.comboBox_COMPortArduino);
            this.groupBox1.Controls.Add(this.label_Baudrate1);
            this.groupBox1.Controls.Add(this.label_COMPort1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label_Status1
            // 
            this.label_Status1.AutoSize = true;
            this.label_Status1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status1.Location = new System.Drawing.Point(70, 105);
            this.label_Status1.Name = "label_Status1";
            this.label_Status1.Size = new System.Drawing.Size(109, 16);
            this.label_Status1.TabIndex = 17;
            this.label_Status1.Text = "Not Connected";
            // 
            // label_ConnectionStatus1
            // 
            this.label_ConnectionStatus1.AutoSize = true;
            this.label_ConnectionStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConnectionStatus1.Location = new System.Drawing.Point(7, 105);
            this.label_ConnectionStatus1.Name = "label_ConnectionStatus1";
            this.label_ConnectionStatus1.Size = new System.Drawing.Size(50, 16);
            this.label_ConnectionStatus1.TabIndex = 16;
            this.label_ConnectionStatus1.Text = "Status: ";
            // 
            // button_Disconnect1
            // 
            this.button_Disconnect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect1.Location = new System.Drawing.Point(167, 128);
            this.button_Disconnect1.Name = "button_Disconnect1";
            this.button_Disconnect1.Size = new System.Drawing.Size(94, 34);
            this.button_Disconnect1.TabIndex = 15;
            this.button_Disconnect1.Text = "Disconnect";
            this.button_Disconnect1.UseVisualStyleBackColor = true;
            this.button_Disconnect1.Click += new System.EventHandler(this.button_Disconnect1_Click);
            // 
            // button_Connect1
            // 
            this.button_Connect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect1.Location = new System.Drawing.Point(10, 128);
            this.button_Connect1.Name = "button_Connect1";
            this.button_Connect1.Size = new System.Drawing.Size(94, 34);
            this.button_Connect1.TabIndex = 14;
            this.button_Connect1.Text = "Connect";
            this.button_Connect1.UseVisualStyleBackColor = true;
            this.button_Connect1.Click += new System.EventHandler(this.button_Connect1_Click);
            // 
            // label_ConnectionName
            // 
            this.label_ConnectionName.AutoSize = true;
            this.label_ConnectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConnectionName.Location = new System.Drawing.Point(6, 16);
            this.label_ConnectionName.Name = "label_ConnectionName";
            this.label_ConnectionName.Size = new System.Drawing.Size(71, 20);
            this.label_ConnectionName.TabIndex = 13;
            this.label_ConnectionName.Text = "Arduino";
            // 
            // comboBox_BaudrateArduino
            // 
            this.comboBox_BaudrateArduino.FormattingEnabled = true;
            this.comboBox_BaudrateArduino.Location = new System.Drawing.Point(73, 72);
            this.comboBox_BaudrateArduino.Name = "comboBox_BaudrateArduino";
            this.comboBox_BaudrateArduino.Size = new System.Drawing.Size(188, 21);
            this.comboBox_BaudrateArduino.TabIndex = 12;
            // 
            // comboBox_COMPortArduino
            // 
            this.comboBox_COMPortArduino.FormattingEnabled = true;
            this.comboBox_COMPortArduino.Location = new System.Drawing.Point(73, 37);
            this.comboBox_COMPortArduino.Name = "comboBox_COMPortArduino";
            this.comboBox_COMPortArduino.Size = new System.Drawing.Size(188, 21);
            this.comboBox_COMPortArduino.TabIndex = 11;
            // 
            // label_Baudrate1
            // 
            this.label_Baudrate1.AutoSize = true;
            this.label_Baudrate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Baudrate1.Location = new System.Drawing.Point(7, 75);
            this.label_Baudrate1.Name = "label_Baudrate1";
            this.label_Baudrate1.Size = new System.Drawing.Size(62, 16);
            this.label_Baudrate1.TabIndex = 10;
            this.label_Baudrate1.Text = "Baudrate";
            // 
            // label_COMPort1
            // 
            this.label_COMPort1.AutoSize = true;
            this.label_COMPort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COMPort1.Location = new System.Drawing.Point(7, 40);
            this.label_COMPort1.Name = "label_COMPort1";
            this.label_COMPort1.Size = new System.Drawing.Size(64, 16);
            this.label_COMPort1.TabIndex = 9;
            this.label_COMPort1.Text = "COM Port";
            // 
            // tabPage_FunctionControl
            // 
            this.tabPage_FunctionControl.Controls.Add(this.groupBox7);
            this.tabPage_FunctionControl.Controls.Add(this.groupBox6);
            this.tabPage_FunctionControl.Controls.Add(this.groupBox5);
            this.tabPage_FunctionControl.Controls.Add(this.groupBox4);
            this.tabPage_FunctionControl.Controls.Add(this.groupBox3);
            this.tabPage_FunctionControl.Location = new System.Drawing.Point(4, 22);
            this.tabPage_FunctionControl.Name = "tabPage_FunctionControl";
            this.tabPage_FunctionControl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_FunctionControl.Size = new System.Drawing.Size(880, 400);
            this.tabPage_FunctionControl.TabIndex = 1;
            this.tabPage_FunctionControl.Text = "Function Control";
            this.tabPage_FunctionControl.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_EvalBoardMessages);
            this.groupBox7.Location = new System.Drawing.Point(397, 269);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(477, 125);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // textBox_EvalBoardMessages
            // 
            this.textBox_EvalBoardMessages.Location = new System.Drawing.Point(6, 10);
            this.textBox_EvalBoardMessages.Multiline = true;
            this.textBox_EvalBoardMessages.Name = "textBox_EvalBoardMessages";
            this.textBox_EvalBoardMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_EvalBoardMessages.Size = new System.Drawing.Size(471, 109);
            this.textBox_EvalBoardMessages.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_ArduinoMessages);
            this.groupBox6.Location = new System.Drawing.Point(6, 269);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(365, 125);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // textBox_ArduinoMessages
            // 
            this.textBox_ArduinoMessages.Location = new System.Drawing.Point(6, 10);
            this.textBox_ArduinoMessages.Multiline = true;
            this.textBox_ArduinoMessages.Name = "textBox_ArduinoMessages";
            this.textBox_ArduinoMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ArduinoMessages.Size = new System.Drawing.Size(353, 109);
            this.textBox_ArduinoMessages.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.button_StopPolling);
            this.groupBox5.Controls.Add(this.button_StopImmobilizer);
            this.groupBox5.Controls.Add(this.button_StartImmobilizer);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.button_StartPolling);
            this.groupBox5.Controls.Add(this.button_GetKeyList);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button_ResetDeviceEvalBoard);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(397, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(477, 257);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Key";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.DropDownStyleChanged += new System.EventHandler(this.DropDownList);
            // 
            // button_StopPolling
            // 
            this.button_StopPolling.Location = new System.Drawing.Point(359, 128);
            this.button_StopPolling.Name = "button_StopPolling";
            this.button_StopPolling.Size = new System.Drawing.Size(88, 34);
            this.button_StopPolling.TabIndex = 12;
            this.button_StopPolling.Text = "Stop";
            this.button_StopPolling.UseVisualStyleBackColor = true;
            this.button_StopPolling.Click += new System.EventHandler(this.button_StopPolling_Click);
            // 
            // button_StopImmobilizer
            // 
            this.button_StopImmobilizer.Location = new System.Drawing.Point(138, 203);
            this.button_StopImmobilizer.Name = "button_StopImmobilizer";
            this.button_StopImmobilizer.Size = new System.Drawing.Size(88, 34);
            this.button_StopImmobilizer.TabIndex = 11;
            this.button_StopImmobilizer.Text = "Stop";
            this.button_StopImmobilizer.UseVisualStyleBackColor = true;
            this.button_StopImmobilizer.Click += new System.EventHandler(this.button_StopImmobilizer_Click);
            // 
            // button_StartImmobilizer
            // 
            this.button_StartImmobilizer.Location = new System.Drawing.Point(12, 203);
            this.button_StartImmobilizer.Name = "button_StartImmobilizer";
            this.button_StartImmobilizer.Size = new System.Drawing.Size(88, 34);
            this.button_StartImmobilizer.TabIndex = 10;
            this.button_StartImmobilizer.Text = "Start Immobilizer ";
            this.button_StartImmobilizer.UseVisualStyleBackColor = true;
            this.button_StartImmobilizer.Click += new System.EventHandler(this.button_StartImmobilizer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Immboilizer Function";
            // 
            // button_StartPolling
            // 
            this.button_StartPolling.Location = new System.Drawing.Point(130, 128);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_ResetDeviceEvalBoard
            // 
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button_ResetDeviceArduino);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 98);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(137, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 34);
            this.button8.TabIndex = 5;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button_ResetDeviceArduino
            // 
            this.button_ResetDeviceArduino.Location = new System.Drawing.Point(11, 44);
            this.button_ResetDeviceArduino.Name = "button_ResetDeviceArduino";
            this.button_ResetDeviceArduino.Size = new System.Drawing.Size(88, 34);
            this.button_ResetDeviceArduino.TabIndex = 4;
            this.button_ResetDeviceArduino.Text = "Reset Device";
            this.button_ResetDeviceArduino.UseVisualStyleBackColor = true;
            this.button_ResetDeviceArduino.Click += new System.EventHandler(this.button_ResetDeviceArduino_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arduino Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_PSActivation);
            this.groupBox3.Controls.Add(this.button_UHFTxActivation);
            this.groupBox3.Controls.Add(this.button_UHFTxActivated);
            this.groupBox3.Controls.Add(this.button_Standby);
            this.groupBox3.Controls.Add(this.button_ImmobilizerActive);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 143);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // button_PSActivation
            // 
            this.button_PSActivation.Location = new System.Drawing.Point(135, 97);
            this.button_PSActivation.Name = "button_PSActivation";
            this.button_PSActivation.Size = new System.Drawing.Size(88, 34);
            this.button_PSActivation.TabIndex = 5;
            this.button_PSActivation.Text = "PS Activation";
            this.button_PSActivation.UseVisualStyleBackColor = true;
            this.button_PSActivation.Click += new System.EventHandler(this.button_PSActivation_Click);
            // 
            // button_UHFTxActivation
            // 
            this.button_UHFTxActivation.Location = new System.Drawing.Point(9, 97);
            this.button_UHFTxActivation.Name = "button_UHFTxActivation";
            this.button_UHFTxActivation.Size = new System.Drawing.Size(88, 34);
            this.button_UHFTxActivation.TabIndex = 4;
            this.button_UHFTxActivation.Text = "UHF Tx Activation";
            this.button_UHFTxActivation.UseVisualStyleBackColor = true;
            this.button_UHFTxActivation.Click += new System.EventHandler(this.button_UHFTxActivation_Click);
            // 
            // button_UHFTxActivated
            // 
            this.button_UHFTxActivated.Location = new System.Drawing.Point(261, 44);
            this.button_UHFTxActivated.Name = "button_UHFTxActivated";
            this.button_UHFTxActivated.Size = new System.Drawing.Size(88, 34);
            this.button_UHFTxActivated.TabIndex = 3;
            this.button_UHFTxActivated.Text = "UHF Tx Activated";
            this.button_UHFTxActivated.UseVisualStyleBackColor = true;
            this.button_UHFTxActivated.Click += new System.EventHandler(this.button_UHFTxActivated_Click);
            // 
            // button_Standby
            // 
            this.button_Standby.Location = new System.Drawing.Point(135, 44);
            this.button_Standby.Name = "button_Standby";
            this.button_Standby.Size = new System.Drawing.Size(88, 34);
            this.button_Standby.TabIndex = 2;
            this.button_Standby.Text = "Standby";
            this.button_Standby.UseVisualStyleBackColor = true;
            this.button_Standby.Click += new System.EventHandler(this.button_Standby_Click);
            // 
            // button_ImmobilizerActive
            // 
            this.button_ImmobilizerActive.Location = new System.Drawing.Point(9, 44);
            this.button_ImmobilizerActive.Name = "button_ImmobilizerActive";
            this.button_ImmobilizerActive.Size = new System.Drawing.Size(88, 34);
            this.button_ImmobilizerActive.TabIndex = 1;
            this.button_ImmobilizerActive.Text = "Immobilizer Active";
            this.button_ImmobilizerActive.UseVisualStyleBackColor = true;
            this.button_ImmobilizerActive.Click += new System.EventHandler(this.button_ImmobilizerActive_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Keyfob Mode List";
            // 
            // tabPage_Test
            // 
            this.tabPage_Test.Controls.Add(this.groupBox8);
            this.tabPage_Test.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Test.Name = "tabPage_Test";
            this.tabPage_Test.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Test.Size = new System.Drawing.Size(880, 400);
            this.tabPage_Test.TabIndex = 2;
            this.tabPage_Test.Text = "Test";
            this.tabPage_Test.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.comboBox2);
            this.groupBox8.Controls.Add(this.button_GetKeyListTest);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.buttonStopTest);
            this.groupBox8.Controls.Add(this.button_StartTest);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(666, 388);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Select Key";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(135, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // button_GetKeyListTest
            // 
            this.button_GetKeyListTest.Location = new System.Drawing.Point(9, 50);
            this.button_GetKeyListTest.Name = "button_GetKeyListTest";
            this.button_GetKeyListTest.Size = new System.Drawing.Size(88, 34);
            this.button_GetKeyListTest.TabIndex = 4;
            this.button_GetKeyListTest.Text = "Get Key List";
            this.button_GetKeyListTest.UseVisualStyleBackColor = true;
            this.button_GetKeyListTest.Click += new System.EventHandler(this.button_GetKeyListTest_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBox_TestMessages);
            this.groupBox9.Location = new System.Drawing.Point(9, 137);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(651, 245);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            // 
            // textBox_TestMessages
            // 
            this.textBox_TestMessages.Location = new System.Drawing.Point(3, 13);
            this.textBox_TestMessages.Multiline = true;
            this.textBox_TestMessages.Name = "textBox_TestMessages";
            this.textBox_TestMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_TestMessages.Size = new System.Drawing.Size(642, 269);
            this.textBox_TestMessages.TabIndex = 0;
            // 
            // buttonStopTest
            // 
            this.buttonStopTest.Location = new System.Drawing.Point(135, 97);
            this.buttonStopTest.Name = "buttonStopTest";
            this.buttonStopTest.Size = new System.Drawing.Size(88, 34);
            this.buttonStopTest.TabIndex = 2;
            this.buttonStopTest.Text = "Stop Test";
            this.buttonStopTest.UseVisualStyleBackColor = true;
            this.buttonStopTest.Click += new System.EventHandler(this.buttonStopTest_Click);
            // 
            // button_StartTest
            // 
            this.button_StartTest.Location = new System.Drawing.Point(9, 97);
            this.button_StartTest.Name = "button_StartTest";
            this.button_StartTest.Size = new System.Drawing.Size(88, 34);
            this.button_StartTest.TabIndex = 1;
            this.button_StartTest.Text = "Start Test";
            this.button_StartTest.UseVisualStyleBackColor = true;
            this.button_StartTest.Click += new System.EventHandler(this.button_StartTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Test List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.tab_Program);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tab_Program.ResumeLayout(false);
            this.tabPage_Connections.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_FunctionControl.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage_Test.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Program;
        private System.Windows.Forms.TabPage tabPage_Connections;
        private System.Windows.Forms.TabPage tabPage_FunctionControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_ConnectionName2;
        private System.Windows.Forms.ComboBox comboBox_BaudrateEvalBoard;
        private System.Windows.Forms.ComboBox comboBox_COMPortEvalBoard;
        private System.Windows.Forms.Label label_Baudrate2;
        private System.Windows.Forms.Label label_COMPort2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Status1;
        private System.Windows.Forms.Label label_ConnectionStatus1;
        private System.Windows.Forms.Button button_Disconnect1;
        private System.Windows.Forms.Button button_Connect1;
        private System.Windows.Forms.Label label_ConnectionName;
        private System.Windows.Forms.ComboBox comboBox_BaudrateArduino;
        private System.Windows.Forms.ComboBox comboBox_COMPortArduino;
        private System.Windows.Forms.Label label_Baudrate1;
        private System.Windows.Forms.Label label_COMPort1;
        private System.Windows.Forms.Label label_Status2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Disconnect2;
        private System.Windows.Forms.Button button_Connect2;
        private System.Windows.Forms.TabPage tabPage_Test;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_PSActivation;
        private System.Windows.Forms.Button button_UHFTxActivation;
        private System.Windows.Forms.Button button_UHFTxActivated;
        private System.Windows.Forms.Button button_Standby;
        private System.Windows.Forms.Button button_ImmobilizerActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button_ResetDeviceArduino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_ResetDeviceEvalBoard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_StopImmobilizer;
        private System.Windows.Forms.Button button_StartImmobilizer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_StartPolling;
        private System.Windows.Forms.Button button_GetKeyList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_StopPolling;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_ArduinoMessages;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox_EvalBoardMessages;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private GroupBox groupBox8;
        private Button buttonStopTest;
        private Button button_StartTest;
        private Label label8;
        private GroupBox groupBox9;
        private TextBox textBox_TestMessages;
        private Button button_GetKeyListTest;
        private Label label9;
        private ComboBox comboBox2;
    }
}

