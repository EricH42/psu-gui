using System;
using System.Collections;
using System.IO.Ports;
using System.Reflection.PortableExecutable;

namespace GUI
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of Form1
            Form1 form1 = new Form1();


            // Show the form
            Application.Run(form1);
        }

    }
}