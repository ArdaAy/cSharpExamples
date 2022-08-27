using System;

namespace _56_MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling 3.25 : " + Math.Ceiling(3.25));
            Console.WriteLine("Flooring 3.25 : " + Math.Floor(3.25));

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}",num1,num2,Math.Min(num1,num2));
            Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}",Math.Pow(3,5));
            Console.WriteLine("PI is {0}",Math.PI);

            Console.WriteLine("The square root of 25 is {0}",Math.Sqrt(25));

            Console.WriteLine("Always positive is {0}",Math.Abs(-25));

            Console.WriteLine("Cos of 1 is {0}",Math.Cos(1));

            
            Run("20");
            Run("asd");
            Run("-1");

        }

        public static void Run(string line)
        {
            Console.WriteLine("");
            Console.WriteLine("Given line is : {0} (range between 0 and 180)", line);
            //string input = Console.ReadLine();
            double parsedVal = 0;
            bool isParsed = double.TryParse(line, out parsedVal);
            if (isParsed)
            {
                if (parsedVal > 0 && parsedVal < 180)
                {
                    Console.WriteLine("Cos = {0}", Math.Cos(ConvertToRadians(parsedVal)));
                    Console.WriteLine("Sin = {0}", Math.Sin(ConvertToRadians(parsedVal)));
                    Console.WriteLine("Tg = {0}", Math.Tan(ConvertToRadians(parsedVal)));
                }
                else
                {
                    Console.WriteLine("Check the input!");
                }
            }
            else
            {
                Console.WriteLine("Check the input!");
            }

        }

        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
