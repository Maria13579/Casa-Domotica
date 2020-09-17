using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Casa_Domotica
{
    class casa
    {
        private SerialPort Arduino = new SerialPort("COM9", 9600);

        public void Enviardato(char d)
        {
            Arduino.Open();
            Arduino.Write("d");
            Arduino.Close();
        }
    }
}
