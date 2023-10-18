using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Keyfob_Tester
{
    public partial class Form1 : Form
    {
        #region Variables

        private SerialPort SerPort_EvalBoard; //serial port
        private string comport;
        string receivedData_EvalBoard = "";
        private string data;
        private string[] data1;
        string testdata = "";
        string completeMessage = "";
        List<string> deviceList;
        string devicename1;
        bool rke_started;
        private bool immo_started;
        #endregion Variables

        #region CommunationInitalize

        public Form1()
        {

            InitializeComponent();

            SerialPort_Configuration();

            label_Status2.ForeColor = Color.DarkOrange;
            label_Status2.Text = "Not Connected";

        }

        private void SerialPort_Configuration()
        {
            string[] ports = SerialPort.GetPortNames();
            string[] baudrates = { "300", "600", "1200", "2400", "4800", "9600", "19200", "57600", "115200" };

            Dictionary<string, string> comPortDevices = FindComPortDevices();

            // ComboBox temizle
            comboBox_COMPortEvalBoard.Items.Clear();

            // Her bir eşleşmeyi ComboBox'a ekleyin
            foreach (var pair in comPortDevices)
            {
                comboBox_COMPortEvalBoard.Items.Add(pair.Key + " " + pair.Value);
            }
            foreach (string baudrate in baudrates)
            {

                comboBox_BaudrateEvalBoard.Items.Add(baudrate);
            }
        }

        public Dictionary<string, string> FindComPortDevices() // COM port adlarını ve cihazları bulan fonksiyon
        {
            List<string> guidarray = new List<string>();
            guidarray.Add("{4d36e978-e325-11ce-bfc1-08002be10318}"); // COM ve LPT Port

            Dictionary<string, string> comPortDevices = new Dictionary<string, string>();

            string ComputerName = "localhost";
            ManagementScope Scope;
            Scope = new ManagementScope(String.Format("\\\\{0}\\root\\CIMV2", ComputerName), null);

            Scope.Connect();

            string query = "SELECT ClassGuid, Name FROM Win32_PnPEntity" + " where ";

            for (int i = 0; i < guidarray.Count; i++)
            {
                query += "ClassGuid='" + guidarray[i] + "'" + " or ";
            }
            query = query.Substring(0, query.Length - 4);

            query = query.Replace("'NULL'", "NULL");

            ObjectQuery Query = new ObjectQuery(query);

            ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

            foreach (ManagementObject WmiObject in Searcher.Get())
            {
                try
                {
                    if (WmiObject["ClassGuid"].ToString() == guidarray[0]
                        && !WmiObject["Name"].ToString().Contains("Communication")
                        && !WmiObject["Name"].ToString().Contains("Bluetooth"))
                    {
                        string deviceName = WmiObject["Name"].ToString();
                        string comPortName = GetComPortName(deviceName); // COM port adını çıkar
                        comPortDevices[comPortName] = deviceName;
                    }
                }
                catch
                { }
            }

            return comPortDevices;
        }

        
        public string GetComPortName(string deviceName) // COM port adını çıkaran fonksiyon
        {
            Match match = Regex.Match(deviceName, @"\bCOM\d+\b");
            if (match.Success)
            {
                return match.Value;
            }
            return string.Empty;
        }

       
      

        private void button_Connect2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = comboBox_COMPortEvalBoard.Text.Split(' ');
                string comPort = null;

                if (parts.Length >= 1)
                {
                    comPort = parts[0];
                }
                SerPort_EvalBoard = new SerialPort();
                SerPort_EvalBoard.BaudRate = Convert.ToInt32(comboBox_BaudrateEvalBoard.Text); ;
                SerPort_EvalBoard.PortName = comPort;
                SerPort_EvalBoard.Parity = Parity.None;
                SerPort_EvalBoard.DataBits = 8;
                SerPort_EvalBoard.StopBits = StopBits.One;
                SerPort_EvalBoard.ReadBufferSize = 20000000;
                SerPort_EvalBoard.DataReceived += SerPort_EvalBoard_DataReceived;

                SerPort_EvalBoard.Open(); //We open the port
                if (SerPort_EvalBoard.IsOpen == true)
                {
                    label_Status2.ForeColor = Color.Green;
                    label_Status2.Text = "Connected";
                    Thread.Sleep(200);
                    tab_Program.SelectedIndex = 1;  

                }

                Thread.Sleep(1000); //We wait a sec
                button_Connect2.Enabled = false;
                button_Disconnect2.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }


        private void button_Disconnect2_Click(object sender, EventArgs e)
        {
            try
            {
                SerPort_EvalBoard.Close(); //We open the port
                if (SerPort_EvalBoard.IsOpen == false)
                {
                    label_Status2.ForeColor = Color.Red;
                    label_Status2.Text = "Disconnected";
                }


                Thread.Sleep(1000); //We wait a sec
                button_Connect2.Enabled = true;
                button_Disconnect2.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }

        #endregion CommunationInitalize

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            Chart_Initalize();
           
        }

        private void Chart_Initalize()
        {
            chart1.Series["CH1"].Points.AddXY(0, 0);
            chart1.Series["CH2"].Points.AddXY(0, 0);
            chart1.Series["CH3"].Points.AddXY(0, 0);
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time";  // Chart X Axis Title
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "RSSI";  // Chart X Axis Title
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{}mV";
            chart1.Series["CH1"].BorderWidth = 2;
            chart1.Series["CH2"].BorderWidth = 2;
            chart1.Series["CH3"].BorderWidth = 2;
            chart1.Invalidate();
        }

        #endregion Form

        #region Message_SendReceive
        private void MessageSender(string Baglanti, string Message)
        {
           
            if (Baglanti == "EvalBoard")
            {
                try
                {
                    if (SerPort_EvalBoard.IsOpen == true )
                    {
                        SerPort_EvalBoard.Write(Message + "\n");
                    }
                    else
                    {
                        MessageBox.Show("Port kapalıyken data gönderilemez!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
        }
        private void SerPort_EvalBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (SerPort_EvalBoard.IsOpen == true)
            {
                receivedData_EvalBoard = SerPort_EvalBoard.ReadLine(); //We read the serial port
                this.Invoke(new Action(ProcessingData_EvalBoard)); //execute the delegate (ProcessingData)
               

            }


            else
            {
                MessageBox.Show("Error!");
            }


        }
        private void ProcessingData_EvalBoard()
        {
            Key_Read();
            RSSI_Read();
            Log_Write();
            RKE_Read();
            Immo_Read();
        }

        private void RKE_Read()
        {
            if (receivedData_EvalBoard.StartsWith("(INF)   Authentication time:") && rke_started )
            {
                string message = receivedData_EvalBoard.ToString();
                if (message.Contains("Not available"))
                {
                    button1.Text = "Yanlış Anahtar";
                    button1.BackColor = Color.Red;
                    button1.ForeColor = Color.White;
                }
                else
                {
                    button1.Text = "Doğru Anahtar";
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                }
                
                

                
            }
        }

        private void Immo_Read()
        {
            if (receivedData_EvalBoard.StartsWith("(INF)   Authentication time:") && immo_started)
            {
                string message = receivedData_EvalBoard.ToString();
                if (message.Contains("Not available"))
                {
                    button2.Text = "Immobilizer Başarısız";
                    button2.BackColor = Color.Red;
                    button2.ForeColor = Color.White;
                }         
                else      
                {         
                    button2.Text = "Immobilizer Başarılı";
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                }




            }
        }

        private void Log_Write()
        {
            textBox_EvalBoardMessages.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + receivedData_EvalBoard.ToString() + Environment.NewLine;
            textBox_EvalBoardMessages.SelectionStart = textBox_EvalBoardMessages.Text.Length;
            textBox_EvalBoardMessages.ScrollToCaret();
        }

        private void RSSI_Read()
        {
            if (receivedData_EvalBoard.StartsWith("(INF)   RSSI result:"))
            {
                string message = receivedData_EvalBoard.ToString();

                // İlgili veriyi bulmak için bir ayracı kullanın
                // string[] parts = message.Split(new string[] { "CH1: ", " mV CH2: ", " mV CH3: ", " mV" }, StringSplitOptions.None);

                string pattern = @"CH1: (\d+\.\d+) mV CH2: (\d+\.\d+) mV CH3: (\d+\.\d+) mV";
                Match match = Regex.Match(message, pattern);

                if (match.Success)
                {
                    // Düzgün çıkarılan verileri kullanın
                    decimal CH1 = decimal.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture);
                    decimal CH2 = decimal.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
                    decimal CH3 = decimal.Parse(match.Groups[3].Value, CultureInfo.InvariantCulture);




                    //textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " CH1: " + CH1.ToString("0.00") + Environment.NewLine;
                    //textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " CH2: " + CH2.ToString("0.00") + Environment.NewLine;
                    //textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " CH3: " + CH3.ToString("0.00") + Environment.NewLine;
                    //grafiğimdeki serilerin sıfırlanması için Clear butonu ile temizleme işlemim


                    //Daha sonra grafikte göstereceğim verileri tanımlama işlemlerimi yapıyorum.
                    chart1.ChartAreas["ChartArea1"].AxisX.Title = "Time";  // Chart X Axis Title
                    chart1.ChartAreas["ChartArea1"].AxisY.Title = "RSSI";  // Chart X Axis Title
                    chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{}mV";
                    chart1.Series["CH1"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), CH1);
                    chart1.Series["CH2"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), CH2);
                    chart1.Series["CH3"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), CH3);
                    chart1.Invalidate();

                }

                //if (parts.Length >= 4)
                //{
                //    // Verileri uygun türde değişkenlere dönüştürün
                //    if (float.TryParse(parts[1], out float CH1))
                //    {
                //        if (float.TryParse(parts[2], out float CH2))
                //        {
                //            if (float.TryParse(parts[3], out float CH3))
                //            {
                //                ////grafiğimdeki serilerin sıfırlanması için Clear butonu ile temizleme işlemim
                //                //foreach (var series in chart1.Series)
                //                //{
                //                //    series.Points.Clear();
                //                //}
                //                //
                //                ////Daha sonra grafikte göstereceğim verileri tanımlama işlemlerimi yapıyorum.
                //                //chart1.Series["CH1"].Points.AddXY("CH1", CH1);
                //                //chart1.Series["CH2"].Points.AddXY("CH2", CH2);
                //                //chart1.Series["CH3"].Points.AddXY("CH3", CH3);
                //
                //                 //Verileri kullanabilirsiniz
                //                textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "CH1: " + CH1 + Environment.NewLine;
                //                textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "CH2: " + CH2 + Environment.NewLine;
                //                textBox1.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "CH3: " + CH3 + Environment.NewLine;
                //            }
                //        }
                //    }
                //}
                //
            }
        }

        private void Key_Read()
        {
            if (receivedData_EvalBoard.StartsWith("(INF)   Found IDE: "))
            {
                data = receivedData_EvalBoard.ToString();
                StringBuilder data1 = new StringBuilder(); // Yeni bir StringBuilder oluşturun
                string pattern = @"(0x[0-9A-Fa-f]+\s*)+";
                //Match match = Regex.Match(data, pattern);
                MatchCollection matches = Regex.Matches(data, pattern);

                foreach (Match match in matches)
                {
                    string hexValues = match.Value;
                    data1.Append(hexValues);
                }

                //string[] hexValuesArray = data1.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] hexValuesArray = data1.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string combinedValues = string.Join(", ", hexValuesArray);
                comboBox1.Items.Add(combinedValues);

                //foreach (string dene in hexValuesArray)
                //{
                //    comboBox1.Items.Add(dene);
                //}
                //if (match.Success) {
                //    string extractedPattern = match.Value.Trim();
                //    textBox_ArduinoMessages.Text = extractedPattern;    
                //}


            }
        }



        private void DropDownList(object sender, EventArgs e)
        {

        }
        #endregion Message_SendReceive

       

        #region EvalBoard_Communication
        private void button_GetKeyList_Click(object sender, EventArgs e)
        {
            keylist();
            
        }
        private void button_StartPolling_Click(object sender, EventArgs e)
        {

            rssi();

        }
        private void button_StopPolling_Click(object sender, EventArgs e)
        {
            stop_rssi();
            Thread.Sleep(500);
            SerPort_EvalBoard.DiscardInBuffer();
            SerPort_EvalBoard.DiscardOutBuffer();
        }

        private void button_StartImmobilizer_Click(object sender, EventArgs e)
        {
            immo();
            immo_started = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_EvalBoardMessages.Text.Length > 0)
                {

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PNG Files|*.png|Text Files|*.txt";
                        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Varsayılan olarak "Belgelerim" klasörü
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string chartFilePath = saveFileDialog.FileName; // Seçilen dosyanın tam yolu
                            string logFilePath = chartFilePath.Replace(".png", ".txt");

                            // Artık dosyaları kaydedebilirsiniz
                            System.IO.File.WriteAllText(logFilePath, textBox_EvalBoardMessages.Text);
                            this.chart1.SaveImage(chartFilePath, ChartImageFormat.Png);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Boş dosya kaydedemezsiniz!");
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_EvalBoardMessages.Clear();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            Chart_Initalize();
        }

        private void button_StopImmobilizer_Click(object sender, EventArgs e)
        {
            stop();
            button2.Text = string.Empty;
            button2.BackColor = Color.White;
            immo_started = false;

        }

        private void button_StartRKE_Click(object sender, EventArgs e)
        {
            rke();
            rke_started = true;
        }

        private void button_StopRKE_Click(object sender, EventArgs e)
        {
            stop();
            button1.Text= string.Empty; 
            button1.BackColor = Color.White;
            rke_started = false;
            
        }

        private void button_ResetDeviceEvalBoard_Click(object sender, EventArgs e)
        {
            reset();
        }

        void keylist()
        {
            MessageSender("EvalBoard", "SPILOG_CONFIG(1);");
            Thread.Sleep(500);
            MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);");
            Thread.Sleep(500);
            MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0 ,0x3 ,0x2 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);");
            Thread.Sleep(500);
            MessageSender("EvalBoard", "PKE_START(0x04, 0x00, 0x01, 0x00, 0x28);");
        }

        void rssi()
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen anahtar seçiniz!");
                }
                else
                {
                    MessageSender("EvalBoard", "SPILOG_CONFIG(1);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0 ,0x3 ,0x0 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "KEYFOB_IDE(" + comboBox1.SelectedItem.ToString() + ");");
                    // SerPort_EvalBoard.Write("KEYFOB_IDE(");
                    // SerPort_EvalBoard.Write(comboBox1.SelectedItem.ToString());
                    // SerPort_EvalBoard.Write(");");
                    // //MessageSender("EvalBoard", "KEYFOB_IDE(0x13, 0x56, 0x57, 0xE3);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_SAVE(3);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "RSSI_CONFIG(33000,32670,270,255);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "PKE_START(3 ,0 ,0x1 ,0 ,0x28 ,0x00 ,0x1 ,0 ,0x28 ,0x02 ,0x0F ,0x9D);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_SAVE(0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "AUTONOMOUS_MODE(1, 2, 1000);");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }

        void stop_rssi()
        {
            MessageSender("EvalBoard", "AUTONOMOUS_MODE(0);");
            comboBox1.Items.Clear();
            comboBox1.Text = string.Empty;  
        }

        void stop()
        {
            MessageSender("EvalBoard", "AUTONOMOUS_MODE(0);");
            Thread.Sleep(200);
            SerPort_EvalBoard.DiscardInBuffer();
            SerPort_EvalBoard.DiscardOutBuffer();
            comboBox1.Items.Clear();
            comboBox1.Text = string.Empty;
        }

        void immo()
        {
            try
            {

                MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(1,0x08,0x04,0x0C,0x40,0x25,0x01,0xD5,0x25,0x10,0x00,0x03,0xFF,0x85,0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0,0xED,0x02,0x38,0x44,0xEB,0x30,0xF0,0x10,0x82,0x38,0x3F,0xEB,0x30,0xF0);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "SPILOG_CONFIG(0);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "RESP_GENERIC_CONFIG(1);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "KEYFOB_IDE();");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "IMMO_SECRETKEY(0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 ,0x00, 0x00, 0x00, 0x00, 0x00, 0x00);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "CMD_SAVE(3);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "IMMO_CHALLENGE();");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "CMD_START_IMMO(1,0x0C,0x01,0x68,0x20,0x81,0x11,0x00,0x12,0x14);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "DELAY(21);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "IMMO_START(0x11,0);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "CMD_SAVE(0);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "AUTONOMOUS_MODE(1, 2, 1000);");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }

        void rke()
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen anahtar seçiniz!");
                }
                else
                {
                    MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(1,0x08,0x04,0x0C,0x40,0x25,0x01,0xD5,0x25,0x10,0x00,0x03,0xFF,0x85,0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0,0xED,0x02,0x38,0x44,0xEB,0x30,0xF0,0x10,0x82,0x38,0x3F,0xEB,0x30,0xF0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "SPILOG_CONFIG(0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "RESP_GENERIC_CONFIG(1);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "KEYFOB_IDE(" + comboBox1.SelectedItem.ToString() + ");");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "IMMO_SECRETKEY(0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 ,0x00, 0x00, 0x00, 0x00, 0x00, 0x00);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_SAVE(3);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "IMMO_CHALLENGE();");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_START_IMMO(1,0x0C,0x01,0x68,0x20,0x81,0x11,0x00,0x12,0x14);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "DELAY(21);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "IMMO_START(0x11,0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "CMD_SAVE(0);");
                    Thread.Sleep(500);
                    MessageSender("EvalBoard", "AUTONOMOUS_MODE(1, 2, 1000);");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }

       

        void reset()
        {
            try
            {

                MessageSender("EvalBoard", "RESET(1);");
                Thread.Sleep(500);
                MessageSender("EvalBoard", "SPILOG_CONFIG(1);");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }



        #endregion EvalBoard_Communication

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if ( SerPort_EvalBoard != null && SerPort_EvalBoard.IsOpen)
                {
                    
                    SerPort_EvalBoard.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}

#region Comment
/*
 * Immobilizer Active
            CMD_CONFIG_DEVICE(1,0x08,0x04,0x0C,0x40,0x25,0x01,0xD5,0x25,0x10,0x00,0x03,0xFF,0x85,0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00);
            CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);
            CMD_CONFIG_DRIVER(0,0xED,0x02,0x38,0x44,0xEB,0x30,0xF0,0x10,0x82,0x38,0x3F,0xEB,0x30,0xF0);
            SPILOG_CONFIG(0);
            RESP_GENERIC_CONFIG(1);
            KEYFOB_IDE();
            IMMO_SECRETKEY(0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 ,0x00, 0x00, 0x00, 0x00, 0x00, 0x00);
            CMD_SAVE(3);
            IMMO_CHALLENGE();
            CMD_START_IMMO(1,0x0C,0x01,0x68,0x20,0x81,0x11,0x00,0x12,0x14);
            DELAY(21);
            IMMO_START(0x11,0);
            CMD_SAVE(0);
            AUTONOMOUS_MODE(1, 2, 1000);
 */

/*
 * Get Key List
            CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);
            CMD_CONFIG_DRIVER(0 ,0x3 ,0x0 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);
            PKE_START(0x04, 0x00, 0x01, 0x00, 0x28);
 */

/*
 * Start Polling
            CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);
            CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);
            CMD_CONFIG_DRIVER(0 ,0x3 ,0x0 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);
            KEYFOB_IDE(0x13, 0x56, 0x57, 0xE3);
            CMD_SAVE(3);
            RSSI_CONFIG(33000,32670,270,255);
            PKE_START(3 ,0 ,0x1 ,0 ,0x28 ,0x00 ,0x1 ,0 ,0x28 ,0x02 ,0x0F ,0x9D);
            CMD_SAVE(0);
            AUTONOMOUS_MODE(1, 2, 1000);
             */

#endregion Comment
