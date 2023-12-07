using System.Diagnostics;
using System.Reflection;
using PS2000GUI;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace GUI
{
    public partial class Form1 : Form
    {
        MqttClient m_Client;
        string clientID;
        string m_PSUID;

        private IPSU psuInstance;


        public Form1()
        {
            InitializeComponent();
            psuInstance = PSUFactory.CreatePSU();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();

            comboBox1.Items.AddRange(portNames);

        }
            
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null)
            {
               string selectedValue = comboBox1.SelectedItem.ToString();

               if(selectedValue != null)
                {
                    psuInstance.comport = selectedValue;
                    txtSubscibe.Text = psuInstance.GetSNR().ToString();
                    //label5.Text = "Connected";

                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string topic = string.Format("/PSU/PSU2000/{0}/{1}/SetVoltage/{2}", m_PSUID, txtPSULabel.Text, txtSetVoltage.Text);
            m_Client.Publish(topic, Encoding.UTF8.GetBytes(topic), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);

        }
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
            //string connectionString = txtConnectionString.Text;
            string connectionString = "localhost";
            m_Client = new MqttClient(connectionString);
            clientID = Guid.NewGuid().ToString();

            m_Client.MqttMsgPublishReceived += M_Client_MqttMsgPublishReceived;

            m_Client.Connect(clientID);

        }
        private void M_Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            string receivedMsg = e.Topic.ToString();


            string[] segments = receivedMsg.Split('/');

            string operation = segments[5];

            if (operation == "")
            {
                label5.Text = receivedMsg.ToString();
            }
            else if (operation == "GetVoltage")
            {

                txtBox_Volt.Text = psuInstance.GetVoltage().ToString();
                txtBox_Current.Text = psuInstance.GetCurrent().ToString();

                label5.Text = receivedMsg.ToString();
            }
            else if (operation == "SetVoltage")
            {
                if (!string.IsNullOrWhiteSpace(txtSetVoltage.Text))
                {
                    psuInstance.SetVoltageValue = segments[6];
                    psuInstance.SetVoltage();
                    txtBox_Volt.Text = psuInstance.GetVoltage().ToString();
                    txtBox_Current.Text = psuInstance.GetCurrent().ToString();
                }
                

                label5.Text = receivedMsg.ToString();
            }
            else
            {
                label5.Text = receivedMsg.ToString();
            }

            this.Invoke((MethodInvoker)delegate () { SetText(receivedMsg); });
        }
        private void SetText(string text)
        {
            this.txtSubscription.Text = text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_Client != null)
            {
                m_Client.Disconnect();
            }
        }
        private void buttonSubscribe_Click(object sender, EventArgs e)
        {
            if (m_Client != null)
            {
                if (txtSubscibe.Text != "")
                { 
                    m_PSUID = txtSubscibe.Text;
                    string topic = string.Format("/PSU/PSU2000/{0}/{1}/#", m_PSUID, txtPSULabel.Text);
                    m_Client.Subscribe(new string[] { topic }, new byte[] { 2 });
                }
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            string topic = string.Format("/PSU/PSU2000/{0}/{1}/{2}", m_PSUID, txtPSULabel.Text, txtPubText.Text);
            m_Client.Publish(topic, Encoding.UTF8.GetBytes(topic), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        private void TurnOnRemote_Click(object sender, EventArgs e)
        {
            psuInstance.RemoteOn();
        }
    }

}