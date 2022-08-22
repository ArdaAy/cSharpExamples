using System;

namespace _42_BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Phillips");
            radio.ListenRadio();
            radio.SwitchOn();
            radio.ListenRadio();

            TV tv = new TV(false, "Sony");
            tv.SwitchOn();
            tv.WatchTV();
            tv.SwitchOff();
            tv.WatchTV();
        }
    }
}
