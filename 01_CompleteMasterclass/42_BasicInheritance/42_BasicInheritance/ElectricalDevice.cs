using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_BasicInheritance
{
    // Parent - Base Class
    class ElectricalDevice
    {
        // boolean to determine the state of the radio
        public bool IsOn { get; set; }

        // string for the brand name of the radio
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        // switch on the radio
        public void SwitchOn()
        {
            IsOn = true;
        }

        // switch off the radio
        public void SwitchOff()
        {
            IsOn = false;
        }

        
    }
}
