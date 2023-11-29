using System.Drawing.Text;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PS2000GUI
{
    public static class PSUFactory
    {
        public static IPSU CreatePSU()
        {
            return new PSU();
        }
    }

    public interface IPSU
    {
        public string voltage { get; set; }
        public string remoteControl { get; set; }
        public string serialNumberString { get; set; }
        public string articleNumber { get; set; }
        public string comport { get; set; }
        List<string> comports { get; set; }

        double GetVoltage();
    }

    public class PSU : IPSU
    {

        public string voltage { get; set; }
        public string remoteControl { get; set; }
        public string serialNumberString { get; set; }
        public string articleNumber { get; set; }
        public string comport { get; set; }
        public List<string> comports { get; set; } = new List<string>();

        public double GetVoltage()
        {
            double volt = 0;
            double percentVolt = 0;
            int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1
            byte SD = Convert.ToByte(SDHex.ToString(), 10);

            //SD, DN, OBJ, DATA, CS
            byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status

            int sum = 0;
            int arrayLength = byteWithOutCheckSum.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += byteWithOutCheckSum[i];
            }

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            if (hexSum.Length == 4)
            {
                cs1 = hexSum.Substring(0, hexSum.Length / 2);
                cs2 = hexSum.Substring(hexSum.Length / 2);
            }
            else if (hexSum.Length == 3)
            {
                cs1 = hexSum.Substring(0, 1);
                cs2 = hexSum.Substring(1);
            }
            else if ((hexSum.Length is 2) || (hexSum.Length is 1))
            {
                cs1 = "0";
                cs2 = hexSum;
            }

            if (cs1 != "")
            {


                byteWithOutCheckSum[arrayLength - 2] = Convert.ToByte(cs1, 16);
                byteWithOutCheckSum[arrayLength - 1] = Convert.ToByte(cs2, 16);
            }

            // now the byte array is ready to be sent

            List<byte> responseTelegram;
            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(byteWithOutCheckSum, 0, byteWithOutCheckSum.Length);
                Thread.Sleep(500);

                responseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        responseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }

            if (responseTelegram == null)
            {
                Console.WriteLine("No telegram was read");
            }
            else
            {

                string percentVoltString = responseTelegram[5].ToString("X") + responseTelegram[6].ToString("X");
                percentVolt = Convert.ToInt32(percentVoltString, 16);


            }

            float nominalVoltage = 0;

            // get nominal voltage
            List<byte> response;
            byte[] bytesToSend = { 0x74, 0x00, 0x02, 0x00, 0x76 };

            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSend, 0, bytesToSend.Length);
                Thread.Sleep(50);
                response = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        response.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (response == null)
            {
                Console.WriteLine("No telegram was read");
            }
            else
            {
                byte[] byteArray = { response[6], response[5], response[4], response[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);
                volt = (double)percentVolt * nominalVoltage / 25600;
                //Console.WriteLine(string.Format("Voltage:{0}", volt));
                //form1.voltage = string.Format("Voltage: {0}", volt);
            }
            return volt;
        }

        public double getCurrent()
        {
            double current = 0;
            double percentVolt = 0;
            int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1
            byte SD = Convert.ToByte(SDHex.ToString(), 10);

            //SD, DN, OBJ, DATA, CS
            byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status

            int sum = 0;
            int arrayLength = byteWithOutCheckSum.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += byteWithOutCheckSum[i];
            }

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            if (hexSum.Length == 4)
            {
                cs1 = hexSum.Substring(0, hexSum.Length / 2);
                cs2 = hexSum.Substring(hexSum.Length / 2);
            }
            else if (hexSum.Length == 3)
            {
                cs1 = hexSum.Substring(0, 1);
                cs2 = hexSum.Substring(1);
            }
            else if ((hexSum.Length is 2) || (hexSum.Length is 1))
            {
                cs1 = "0";
                cs2 = hexSum;
            }

            if (cs1 != "")
            {


                byteWithOutCheckSum[arrayLength - 2] = Convert.ToByte(cs1, 16);
                byteWithOutCheckSum[arrayLength - 1] = Convert.ToByte(cs2, 16);
            }

            // now the byte array is ready to be sent

            List<byte> responseTelegram;
            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(byteWithOutCheckSum, 0, byteWithOutCheckSum.Length);
                Thread.Sleep(500);

                responseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        responseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }

            float nominalCurrent= 0;

            // get nominal voltage
            List<byte> response;
            //SD, DN, OBJ, DATA, CS
            byte[] bytesToSend = { 0x74, 0x00, 0x03, 20, 0x76 };

            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSend, 0, bytesToSend.Length);
                Thread.Sleep(50);
                response = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        response.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (response == null)
            {
                Console.WriteLine("No telegram was read");
            }
            else
            {
                byte[] byteArray = { response[6], response[5], response[4], response[3] };
                nominalCurrent = BitConverter.ToSingle(byteArray, 0);
                current = (double)percentVolt * nominalCurrent / 25600;
                //Console.WriteLine(string.Format("Voltage:{0}", volt));
                //form1.voltage = string.Format("Voltage: {0}", volt);
            }
            return nominalCurrent;

        }
    }
}