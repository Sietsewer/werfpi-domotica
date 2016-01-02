using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace raspberry_interface
{
    [Serializable]
    class Settings
    {
        //singleton pattern
        private static Settings _instance;
        public static Settings instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                _instance = loadValues();
                return _instance;

            }
            private set
            {

            }
        }

        public static void saveValues()
        {
            saveValues(instance);
        }
        [NonSerialized]
        public static bool init = false;

        public float Hysteresis = 1f;
        public float HysteresisOffset = 1f;
        public float MinimumTemperature = 5f;
        public float MaximumTemperature = 30f;

        private static Settings loadValues()
        {
            Settings settings;
            string fileName = MethodBase.GetCurrentMethod().DeclaringType.Name + ".dat";
            string fileDirAndName = Application.StartupPath + Path.DirectorySeparatorChar + fileName;
            IFormatter formatter = new SoapFormatter();
            if (File.Exists(fileDirAndName))
            {
                Stream stream = new FileStream(fileDirAndName, FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    settings = (Settings)formatter.Deserialize(stream);
                }
                catch (SerializationException)
                {
                    settings = new Settings();
                }
                finally
                {
                    stream.Close();
                }
            }
            else
            {
                settings = new Settings();
                Stream stream = new FileStream(fileDirAndName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, settings);
                stream.Close();
            }

            init = true;

            return settings;
        }

        private static void saveValues(Settings settings)
        {
            string fileName = MethodBase.GetCurrentMethod().DeclaringType.Name + ".dat";
            string fileDirAndName = Application.StartupPath + Path.DirectorySeparatorChar + fileName;
            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream(fileDirAndName, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                formatter.Serialize(stream, settings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                stream.Close();
            }
        }

        ~Settings()
        {
            if (this == _instance)
            {
                saveValues(this);
            }
        }
    }
}
