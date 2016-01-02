using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaspberryGPIOManager;

namespace raspberry_interface
{
    class Thermostat
    {
        private TemperatureSensor tempSensor;
        private GPIOPinDriver[] valvePins;

        private bool _isHeating = false;
        public bool isHeating
        {
            get
            {

                return _isHeating;
            }
            private set
            {
                _isHeating = value;
            }
        }

        public float targetTemperature
        {
            get; set;
        }
        public Thermostat(GPIOPinDriver[] valvePins, TemperatureSensor tempSensor)
        {

        }
    }
}
