using System;
using System.Globalization;

namespace _08_ImplicitExplicitConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // impicit conversion
            int num = 12340532;
            long bigNum = num;

            float myFloat = 15.77F;
            double myNewDouble = myFloat;

            double myDouble = 15.77;
            int myInt;
            // explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            // typeConversion 
            string myString = myDouble.ToString(); // "15.77"
            string myFloatString = myFloat.ToString();
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();

            // Parsing a String to an Integer
            myString = "15";
            string mySecondString = "13";
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);
            int resultInt = num1 + num2;
            string result = myString + mySecondString;

            Console.WriteLine(resultInt);
            Console.Read();

            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            //using System.Globalization; to the top for CultureInfo class
            // without using CultureInfo, result can be 85 because of the differance of national punctuation rules (dot ("."))
            // or simply change "." with ","
            // float f = float.Parse(stringForFloat);
            float f = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);
            int i = Int32.Parse(stringForInt);

            Console.WriteLine("Float parsing : {0} , Integer parsing: {1}",f,i);
        }
    }
}
