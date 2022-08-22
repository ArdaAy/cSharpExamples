using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_BasicInheritance
{
    // Child Class Inherited from ElectricalDevice
    class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand) { }


        // method to listen to the radio
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                // listen to radio
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                // print error message
                Console.WriteLine("Radio is swtiched off, switch it on first!");
            }
        }
    }


}
