using System;

namespace _05_PrimitiveExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring multiple variables at once
            //int num3, num4, num5;

            // Declaring a variable
            int num1 = 13;
            int num2 = 5;

            // Using calculation
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            string name = "Dolmaci";

            string capsMessage = "This is a caps message!";

            Console.WriteLine("My name is" + name);
            Console.WriteLine(capsMessage.ToUpper());
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);
            Console.WriteLine("f1 / f2 is " + fDiv);
            Console.Read();
        }
    }
}
