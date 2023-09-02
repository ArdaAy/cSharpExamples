using System;

namespace _01_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var Timer = new Stopwatch();
            var ProgramRunning = true;
            while (ProgramRunning)
            {
                ActionPrinter();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Timer.Start();
                        break;
                    case "2":
                        Timer.End();
                        break;
                    case "3":
                        Timer.GetTimespan();
                        break;
                    case "4":
                        Timer.ResetTime(1);
                        break;
                    case "5":
                        Console.WriteLine("Program has been ended. Goodbye.");
                        ProgramRunning = false;
                        break;
                    default: 
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine();
            }
        }

        private static void ActionPrinter()
        {
            Console.WriteLine("Select Actions below");
            Console.WriteLine("1-Start Timer");
            Console.WriteLine("2-End Timer");
            Console.WriteLine("3-Show Timespan");
            Console.WriteLine("4-Reset");
            Console.WriteLine("5-Quit");
        }
    }
}
