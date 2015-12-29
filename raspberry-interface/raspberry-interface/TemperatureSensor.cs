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

        public bool IsConnected { get
            {
                return connected;
            }
            set
            {
                connected = value;
            }
        }

        public string Temperature { get; set; }

        Thread readTempThread;
        public TemperatureSensor(string sensorID, string location, string function, uint readDelay = 0)
        {
            this.SensorID = sensorID;
            this.Location = location;
            this.Function = function;
            this.readDelay = readDelay;

            if (Directory.Exists(SensorModulePath + this.SensorID))
            {
                connected = true;
                readTempThread = new Thread(getTemp);
            }
        }

        public void getTemp()
        {
            string file;
            string[] temp;
            string fileName = SensorModulePath + SensorID + SensorFileName;
            Temperature = fileName;
            while (connected)
            {
                try
                {
                    file = File.ReadAllText(fileName);
                    temp = file.Split('=');
                    Temperature = temp[temp.Length - 1];
                }
                catch (IOException e)
                {
                    throw e;
                }
                if (readDelay > 0)
                {
                    Thread.Sleep((int)readDelay);
                }
            }
        }

        ~TemperatureSensor()
        {
            if(readTempThread!=null && readTempThread.IsAlive)
                readTempThread.Abort();
        }
    }
}
