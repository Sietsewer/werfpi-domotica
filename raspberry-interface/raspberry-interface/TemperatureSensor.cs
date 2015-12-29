using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace raspberry_interface
{

    class TemperatureSensor
    {
        public static string SensorModulePath = "/sys/bus/w1/devices/";
        public static string SensorFileName = "/w1_slave";

        private uint readDelay;

        public string SensorID { get; set; }
        public string Location { get; set; }
        public string Function { get; set; }

        public bool connected = false;

        public string Temperature { get; set; }

        public TemperatureSensor(string sensorID, string location, string function, uint readDelay = 0)
        {
            this.SensorID = sensorID;
            this.Location = location;
            this.Function = function;
            this.readDelay = readDelay;

            if (Directory.Exists(SensorModulePath + this.SensorID))
            {
                connected = true;
            }
        }

        public void getTemp()
        {
            string file;
            string[] temp;
            string fileName = SensorModulePath + SensorID + SensorFileName;
            while (connected)
            {
                try
                {
                    /*file = File.ReadAllText(fileName);
                    temp = file.Split('=');
                    Temperature = file;*/
                }
                catch (IOException e)
                {
                    throw e;
                }

                Temperature = DateTime.Now.ToString();

                if (readDelay > 0)
                {
                    Thread.Sleep((int)readDelay);
                }
            }
        }
    }
}
