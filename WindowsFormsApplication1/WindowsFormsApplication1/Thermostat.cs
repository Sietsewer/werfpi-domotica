using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Thermostat
    {
        
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
        
        float maxTemp;
        float minTemp;

        public Thermostat (float maxTemp, float minTemp)
        {

        }
    }
}
