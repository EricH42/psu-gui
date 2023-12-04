using System.Diagnostics;
using System.Reflection;
using PS2000GUI;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Text;
using System.Windows.Forms;

namespace GUI
{


    public partial class Form1 : Form
    {
        /*
        private Class1 class1 = new Class1();
           
        public string voltage { get; set; }
        public string remoteControl { get; set; }
        public string serialNumberString { get; set; }
        public string articleNumber { get; set; }

        private string comport = "";
        */
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
            //display();
            //psuInstance.comport = txtBoxComport.Text;
            if (!comboBox1.Items.Contains(txtBoxComport.Text) && !string.IsNullOrWhiteSpace(txtBoxComport.Text))
            {
                comboBox1.Items.Add(txtBoxComport.Text);
            }
            
            //txtBox_Volt.Text = psuInstance.GetVoltage().ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
    

            if (comboBox1.SelectedItem != null)
            {
                // Get the selected item
               string selectedValue = comboBox1.SelectedItem.ToString();

               if(selectedValue != null)
                {
                    psuInstance.comport = selectedValue;
                    txtBox_Volt.Text = psuInstance.GetVoltage().ToString();
                    txtBox_Current.Text = psuInstance.GetCurrent().ToString();
                    label5.Text = "Connected";
                   
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string connectionString = txtConnectionString.Text;
            m_Client = new MqttClient(connectionString);
            clientID = Guid.NewGuid().ToString();

            m_Client.MqttMsgPublishReceived += M_Client_MqttMsgPublishReceived;

            m_Client.Connect(clientID);
        }
        private void M_Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {

            string receivedMsg = e.Topic.ToString();
            this.Invoke((MethodInvoker)delegate () { SetText(receivedMsg); });
        }
        private void SetText(string text)
        {
            this.txtSubscription.Text = text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
                    string topic = string.Format("/PSU/PSU2000/{0}/#", m_PSUID);
                    m_Client.Subscribe(new string[] { topic }, new byte[] { 2 });
                }
            }
        }

        private void buttonPublish_Click(object sender, EventArgs e)
        {
            string topic = string.Format("/PSU/PSU2000/{0}/{1}", m_PSUID, txtPubText.Text);
            m_Client.Publish(topic, Encoding.UTF8.GetBytes(topic), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }
    }
    
}