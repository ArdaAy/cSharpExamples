using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_BasicInheritance
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand):base(isOn, brand) { }

        public void WatchTV()
        {
            //first check if the TV is on
            if (IsOn)
            {
                // Watch TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                // print error message
                Console.WriteLine("TV is swtiched off, switch it on first!");
            }
        }

    }
}
