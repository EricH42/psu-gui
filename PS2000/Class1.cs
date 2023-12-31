﻿using System.Collections;
using System.Drawing.Text;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
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
        public string current { get; set; }
        public string comport { get; set; }
        public string SetVoltageValue { get; set; }

        double GetVoltage();
        double GetCurrent();
        string GetSNR();
        void SetVoltage();
        void RemoteOn();

    }

    public class PSU : IPSU
    {

        public string voltage { get; set; }
        public string current { get; set; }
        public string comport { get; set; }
        public string SetVoltageValue { get; set; }


        public double GetVoltage()
        {
            byte[] bytesToSend = { 0x74, 0x00, 0x02, 0x00, 0x76 };
            return queryData(bytesToSend);
        }
        public double GetCurrent()
        {
            byte[] bytesToSend = { 0x74, 0x00, 0x03, 0x00, 0x77 };
            return queryData(bytesToSend);
        }
        public string GetSNR()
        {
            byte[] bytesTosend = { 0x74, 0x00, 0x01, 0x00, 0x75 };
            return querySNR(bytesTosend);
        }
        public void RemoteOn()
        {
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


            byte[] bytesToSendToTurnOnRC = new byte[] { 0xF1, 0x00, 0x36, 0x10, 0x10, 0x01, 0x47 }; // Turn on remote control
            List<byte> RCresponse;
            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                port.Write(bytesToSendToTurnOnRC, 0, bytesToSendToTurnOnRC.Length);
                Thread.Sleep(50);
                RCresponse = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        RCresponse.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
                if (RCresponse[3] == 0)
                {
                    Console.WriteLine("Remote Control is turned on");
                }
                else
                {
                    Console.WriteLine(String.Format("Remote control is not turned on due to error: {0}", RCresponse[3].ToString()));
                }
            }
        }
        public void SetVoltage()
        {
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

            float VoltValue = float.Parse(SetVoltageValue);
            float setVolt = VoltValue;
            int percentSetValue = (int)Math.Round((25600 * setVolt) / 84);

            string hexValue = percentSetValue.ToString("X");
            string hexValue1 = "";
            string hexValue2 = "";

            if (hexValue.Length == 4)
            {
                hexValue1 = hexValue.Substring(0, hexValue.Length / 2);
                hexValue2 = hexValue.Substring(hexValue.Length / 2);
            }
            else if (hexValue.Length == 3)
            {
                hexValue1 = hexValue.Substring(0, 1);
                hexValue2 = hexValue.Substring(1);
            }
            else if ((hexValue.Length is 2) || (hexValue.Length is 1))
            {
                hexValue1 = "0";
                hexValue2 = hexValue;
            }
            byte[] newbytesWithoutChecksum = { 0xF2, 0x00, 0x32, Convert.ToByte(hexValue1, 16), Convert.ToByte(hexValue2, 16), 0x0, 0x0 };

            int newsum = 0;
            int newarrayLength = newbytesWithoutChecksum.Length;
            for (int i = 0; i < newarrayLength; i++)
            {
                newsum += newbytesWithoutChecksum[i];
            }

            string newhexSum = newsum.ToString("X");
            string newcs1 = "";
            string newcs2 = "";
            if (hexSum.Length == 4)
            {
                newcs1 = newhexSum.Substring(0, newhexSum.Length / 2);
                newcs2 = newhexSum.Substring(newhexSum.Length / 2);
            }
            else if (newhexSum.Length == 3)
            {
                newcs1 = newhexSum.Substring(0, 1);
                newcs2 = newhexSum.Substring(1);
            }
            else if ((newhexSum.Length is 2) || (newhexSum.Length is 1))
            {
                newcs1 = "0";
                newcs2 = newhexSum;
            }

            if (newcs1 != "")
            {


                newbytesWithoutChecksum[newarrayLength - 2] = Convert.ToByte(newcs1, 16);
                newbytesWithoutChecksum[newarrayLength - 1] = Convert.ToByte(newcs2, 16);
            }

            List<byte> newResponseTelegram;
            using (SerialPort port = new SerialPort(comport, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(newbytesWithoutChecksum, 0, newbytesWithoutChecksum.Length);
                Thread.Sleep(500);

                newResponseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        newResponseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
            }
            if (newResponseTelegram[3] == 0)
            {
                Console.WriteLine("New voltage was set");
            }
            else
            {
                Console.WriteLine(newResponseTelegram[3].ToString());
            }
        }


        public double queryData(byte[] bytesToSend)
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
            //byte[] bytesToSend = { 0x74, 0x00, 0x02, 0x00, 0x76 };

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
            }
            return volt;
        }




        public string querySNR(byte[] bytesToSend)
        {
            string SNR = "";
          
            List<byte> response;
        

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
                byte[] byteArray = { response[3],response[4], response[5], response[6], response[7], response[8], response[9], response[10], response[11], response[12] };
                SNR = Encoding.ASCII.GetString(byteArray);

            }
            return SNR;
        }
        
    }
}