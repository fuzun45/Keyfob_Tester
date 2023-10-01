using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyfob_Tester
{
    public partial class Form1 : Form
    {
        
        private SerialPort SerPort_Arduino; //serial port
        private SerialPort SerPort_EvalBoard; //serial port
        private string comport;
        string receivedData_EvalBoard = "";
        string receivedData_Arduino = "";
        private string data;
        private string[] data1;

        #region CommunationInitalize

        public Form1()
        {
            //SerPort_EvalBoard.DataReceived += new SerialDataReceivedEventHandler();
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            string[] baudrates = { "300", "600", "1200", "2400", "4800", "9600", "19200", "57600", "115200" };
            foreach (string port in ports)
            {
                comboBox_COMPortArduino.Items.Add(port);
                comboBox_COMPortEvalBoard.Items.Add(port);
            }

            foreach (string baudrate in baudrates)
            {
                comboBox_BaudrateArduino.Items.Add(baudrate);
                comboBox_BaudrateEvalBoard.Items.Add(baudrate);
            }

            label_Status1.ForeColor = Color.DarkOrange;
            label_Status1.Text = "Not Connected";
            label_Status2.ForeColor = Color.DarkOrange;
            label_Status2.Text = "Not Connected";



            //comboBox_BaudrateArduino.Items.Add("300");
            //comboBox_BaudrateArduino.Items.Add("600");
            //comboBox_BaudrateArduino.Items.Add("1200");
            //comboBox_BaudrateArduino.Items.Add("2400");
            //comboBox_BaudrateArduino.Items.Add("4800");
            //comboBox_BaudrateArduino.Items.Add("9600");
            //comboBox_BaudrateArduino.Items.Add("19200");
            //comboBox_BaudrateArduino.Items.Add("57600");
            //comboBox_BaudrateArduino.Items.Add("115200");
            //
            //comboBox_BaudrateEvalBoard.Items.Add("300");
            //comboBox_BaudrateEvalBoard.Items.Add("600");
            //comboBox_BaudrateEvalBoard.Items.Add("1200");
            //comboBox_BaudrateEvalBoard.Items.Add("2400");
            //comboBox_BaudrateEvalBoard.Items.Add("4800");
            //comboBox_BaudrateEvalBoard.Items.Add("9600");
            //comboBox_BaudrateEvalBoard.Items.Add("19200");
            //comboBox_BaudrateEvalBoard.Items.Add("57600");
            //comboBox_BaudrateEvalBoard.Items.Add("115200");
        }


        private void button_Connect1_Click(object sender, EventArgs e)
        {
            SerPort_Arduino = new SerialPort();
            SerPort_Arduino.BaudRate = Convert.ToInt32(comboBox_BaudrateArduino.Text); ;
            SerPort_Arduino.PortName = comboBox_COMPortArduino.Text;
            SerPort_Arduino.Parity = Parity.None;
            SerPort_Arduino.DataBits = 8;
            SerPort_Arduino.StopBits = StopBits.One;
            SerPort_Arduino.ReadBufferSize = 20000000;
            SerPort_Arduino.DataReceived += SerPort_Arduino_DataReceived;

            try
            {
                SerPort_Arduino.Open(); //We open the port
                if (SerPort_Arduino.IsOpen == true)
                {
                    label_Status1.ForeColor = Color.Green;
                    label_Status1.Text = "Connected";
                }


                Thread.Sleep(1000); //We wait a sec
                button_Connect1.Enabled = false;
                button_Disconnect1.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }

       

        private void button_Disconnect1_Click(object sender, EventArgs e)
        {
            try
            {
                SerPort_Arduino.Close(); //We open the port
                if (SerPort_Arduino.IsOpen == false)
                {
                    label_Status1.ForeColor = Color.Red;
                    label_Status1.Text = "Disconnected";
                }


                Thread.Sleep(1000); //We wait a sec
                button_Connect1.Enabled = true;
                button_Disconnect1.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }

        private void button_Connect2_Click(object sender, EventArgs e)
        {
            SerPort_EvalBoard = new SerialPort();
            SerPort_EvalBoard.BaudRate = Convert.ToInt32(comboBox_BaudrateEvalBoard.Text); ;
            SerPort_EvalBoard.PortName = comboBox_COMPortEvalBoard.Text;
            SerPort_EvalBoard.Parity = Parity.None;
            SerPort_EvalBoard.DataBits = 8;
            SerPort_EvalBoard.StopBits = StopBits.One;
            SerPort_EvalBoard.ReadBufferSize = 20000000;
            SerPort_EvalBoard.DataReceived += SerPort_EvalBoard_DataReceived;

            try
            {
                SerPort_EvalBoard.Open(); //We open the port
                if (SerPort_EvalBoard.IsOpen == true)
                {
                    label_Status2.ForeColor = Color.Green;
                    label_Status2.Text = "Connected";
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
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (SerPort_Arduino.IsOpen == true || SerPort_EvalBoard.IsOpen == true)
                {
                    SerPort_Arduino.Close();
                    SerPort_EvalBoard.Close();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
        }

        #endregion Form

        #region Message_SendReceive
        private void MessageSender(string Baglanti, string Message)
        {
            if (Baglanti == "Arduino")
            {
                try
                {
                    if (SerPort_Arduino.IsOpen == true)
                    {
                        SerPort_Arduino.Write(Message + "\n");
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
            else if (Baglanti == "EvalBoard")
            {
                try
                {
                    if (SerPort_EvalBoard.IsOpen == true)
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
        private void SerPort_Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            receivedData_Arduino = SerPort_Arduino.ReadLine(); //We read the serial port

            this.Invoke(new Action(ProcessingData_Arduino)); //execute the delegate (ProcessingData)
        }
        private void SerPort_EvalBoard_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (SerPort_EvalBoard.IsOpen == true)
            {
                receivedData_EvalBoard = SerPort_EvalBoard.ReadLine(); //We read the serial port

                if (receivedData_EvalBoard.StartsWith("(INF)"))
                {
                    this.Invoke(new Action(ProcessingData_EvalBoard)); //execute the delegate (ProcessingData)
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }
            
            
        }
        private void ProcessingData_EvalBoard()
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
            textBox_EvalBoardMessages.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + receivedData_EvalBoard.ToString() + Environment.NewLine;
            //We put the received data in the textbox and add a linebreak
            textBox_EvalBoardMessages.SelectionStart = textBox_EvalBoardMessages.Text.Length;
            textBox_EvalBoardMessages.ScrollToCaret();

        }
        private void ProcessingData_Arduino()
        {
            textBox_ArduinoMessages.Text += DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + receivedData_Arduino.ToString() + Environment.NewLine;
            //We put the received data in the textbox and add a linebreak
            textBox_ArduinoMessages.SelectionStart = textBox_ArduinoMessages.Text.Length;
            textBox_ArduinoMessages.ScrollToCaret();
        }

        private void DropDownList(object sender, EventArgs e)
        {

        }
        #endregion Message_SendReceive

        #region Arduino_Communication

        private void button_ImmobilizerActive_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "1");
        }

        private void button_Standby_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "2");
        }

        private void button_UHFTxActivated_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "3");
        }

        private void button_UHFTxActivation_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "4");
        }

        private void button_PSActivation_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "5");
        }

        private void button_ResetDeviceArduino_Click(object sender, EventArgs e)
        {
            MessageSender("Arduino", "6");
        }

        #endregion Arduino_Communication

        #region EvalBoard_Communication
        private void button_GetKeyList_Click(object sender, EventArgs e)
        {
            MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);");
            MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0 ,0x3 ,0x0 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);");
            MessageSender("EvalBoard", "PKE_START(0x04, 0x00, 0x01, 0x00, 0x28);");
        }
        private void button_StartPolling_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen anahtar seçiniz!");
                }
                else
                {
                    MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(0 ,0x08 ,0x4 ,0x0C ,0x40 ,0x21 ,0x1 ,0xd5 ,0xff ,0x10 ,0x00 ,0x03 ,0xFF ,0x85 ,0xff ,0xff ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0 ,0x0);");
                    MessageSender("EvalBoard", "CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);");
                    MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0 ,0x3 ,0x0 ,0x38 ,0x44 ,0x2b ,0x30 ,0xf0);");
                    SerPort_EvalBoard.Write("KEYFOB_IDE(");
                    SerPort_EvalBoard.Write(comboBox1.SelectedItem.ToString());
                    SerPort_EvalBoard.Write(");");
                    //MessageSender("EvalBoard", "KEYFOB_IDE(0x13, 0x56, 0x57, 0xE3);");
                    MessageSender("EvalBoard", "CMD_SAVE(3);");
                    MessageSender("EvalBoard", "RSSI_CONFIG(33000,32670,270,255);");
                    MessageSender("EvalBoard", "PKE_START(3 ,0 ,0x1 ,0 ,0x28 ,0x00 ,0x1 ,0 ,0x28 ,0x02 ,0x0F ,0x9D);");
                    MessageSender("EvalBoard", "CMD_SAVE(0);");
                    MessageSender("EvalBoard", "AUTONOMOUS_MODE(1, 2, 1000);");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error!");
            }
            

        }
        private void button_StopPolling_Click(object sender, EventArgs e)
        {
            MessageSender("EvalBoard", "AUTONOMOUS_MODE(0);");
            comboBox1.Items.Clear();    
        }

        private void button_StartImmobilizer_Click(object sender, EventArgs e)
        {

            MessageSender("EvalBoard", "CMD_CONFIG_DEVICE(1,0x08,0x04,0x0C,0x40,0x25,0x01,0xD5,0x25,0x10,0x00,0x03,0xFF,0x85,0xFF,0xFF,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00);");
            MessageSender("EvalBoard", "CMD_CONFIG_ADVANCED(1,0x03,0xBB,0xB3,0xE5,0x15,0xF2);");
            MessageSender("EvalBoard", "CMD_CONFIG_DRIVER(0,0xED,0x02,0x38,0x44,0xEB,0x30,0xF0,0x10,0x82,0x38,0x3F,0xEB,0x30,0xF0);");
            MessageSender("EvalBoard", "SPILOG_CONFIG(0);");
            MessageSender("EvalBoard", "RESP_GENERIC_CONFIG(1);");
            MessageSender("EvalBoard", "KEYFOB_IDE();");
            MessageSender("EvalBoard", "IMMO_SECRETKEY(0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 ,0x00, 0x00, 0x00, 0x00, 0x00, 0x00);");
            MessageSender("EvalBoard", "CMD_SAVE(3);");
            MessageSender("EvalBoard", "IMMO_CHALLENGE();");
            MessageSender("EvalBoard", "CMD_START_IMMO(1,0x0C,0x01,0x68,0x20,0x81,0x11,0x00,0x12,0x14);");
            MessageSender("EvalBoard", "DELAY(21);");
            MessageSender("EvalBoard", "IMMO_START(0x11,0);");
            MessageSender("EvalBoard", "CMD_SAVE(0);");
            MessageSender("EvalBoard", "AUTONOMOUS_MODE(1, 2, 1000);");
        }

        private void button_StopImmobilizer_Click(object sender, EventArgs e)
        {
            MessageSender("EvalBoard", "AUTONOMOUS_MODE(0);");
        }







        #endregion EvalBoard_Communication

        
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
