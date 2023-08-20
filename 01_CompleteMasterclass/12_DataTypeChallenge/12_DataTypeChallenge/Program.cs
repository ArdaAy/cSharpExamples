using System;

namespace _12_DataTypeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Types
            // https://docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2008/ms228360(v=vs.90)?redirectedfrom=MSDN

            byte myByte = 25;
            Console.WriteLine(myByte);

            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);

            int myInt = -12318925;
            Console.WriteLine(myInt);

            uint myUint = 123091;
            Console.WriteLine(myUint);

            short myShort = -32768;
            Console.WriteLine(myShort);

            ushort myUShort = 65535;
            Console.WriteLine(myUShort);

            float myFloat = -31.1289f;
            Console.WriteLine(myFloat);

            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);

            char myCharacter = 'A';
            Console.WriteLine(myCharacter);

            bool myBool = true;
            Console.WriteLine(myBool);

            string myText = "I control text";
            Console.WriteLine(myText);

            string numText = "15";
            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
