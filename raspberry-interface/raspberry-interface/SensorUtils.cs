using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace raspberry_interface
{
    class SensorUtils
    {
        private static string sensorIdNamesLocation = "/home/pi/domotica/sensor-id-names.dat";
        public struct TemperatureSensorData
        {
            public string SensorID { get; set; }
            public string Location { get; set; }
            public string Function { get; set; }
        }

        public static TemperatureSensorData[] connectedSensors()
        {
            TemperatureSensorData[] sensors;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(TemperatureSensor.SensorModulePath);
                DirectoryInfo[] directories = directory.GetDirectories();
                sensors = new TemperatureSensorData[directories.Length];
                for (int i = 0; i < directories.Length; i++)
                {
                    sensors[i].SensorID = directories[i].Name;
                }
            }
            catch (DirectoryNotFoundException)
            {
                return sensors = new TemperatureSensorData[0];
            }
            return sensors;
        }

        public static TemperatureSensorData[] listedSensors()
        {
            TemperatureSensorData[] sensors;
            string[] split;
            try
            {
                string[] file = File.ReadAllLines(sensorIdNamesLocation);
                sensors = new TemperatureSensorData[file.Length];
                for (int i = 0; i < file.Length; i++)
                {
                    split = file[i].Split(';');
                    sensors[i].SensorID = split[0];
                    sensors[i].Location = split[1];
                    sensors[i].Function = split[2];
                }
            }
            catch (DirectoryNotFoundException)
            {
				return sensors = new TemperatureSensorData[0];
            }
            return sensors;
        }

        public static TemperatureSensorData[] allSensors(bool debug = false)
        {
            if (!debug)
            {
                List<TemperatureSensorData> connected = new List<TemperatureSensorData>(connectedSensors());
                List<TemperatureSensorData> listed = new List<TemperatureSensorData>(listedSensors());
                List<TemperatureSensorData> sensors = new List<TemperatureSensorData>();
                foreach (TemperatureSensorData one in connected)
                {
                    TemperatureSensorData sensorToAdd = one;
                    foreach (TemperatureSensorData two in listed)
                    {
                        if (two.SensorID == one.SensorID)
                            sensorToAdd = two;
                    }
					if(!sensorToAdd.SensorID.Contains("w1_"))
                    	sensors.Add(sensorToAdd);
                }
                return sensors.ToArray();
            }
            else
            {
                List<TemperatureSensorData> sensors = new List<TemperatureSensorData>();
                TemperatureSensorData s1 = new TemperatureSensorData();
                s1.SensorID = "bob";
                TemperatureSensorData s2 = new TemperatureSensorData();
                s2.SensorID = "ben";
                s2.Function = "niets";
                TemperatureSensorData s3 = new TemperatureSensorData();
                s3.SensorID = "marvine";
                s3.Function = "ook niets";
                s3.Location = "nergens";
                sensors.Add(s1);
                sensors.Add(s2);
                sensors.Add(s3);
                return sensors.ToArray();
            }
        }

    }
}
