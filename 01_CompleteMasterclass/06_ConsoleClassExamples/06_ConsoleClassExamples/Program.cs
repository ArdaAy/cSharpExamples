using System;

namespace _06_ConsoleClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string and press enter:");
            string readInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You have entered : "+readInput);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter a string and press enter:");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII Value is {0},{1}", asciiValue, " Test Value");
        }
    }
}
