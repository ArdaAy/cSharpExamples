using System;

namespace _03_HelloWorld
{
    class Program
    {
        // Entry point of our program
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first C# project!");
            
            // Running this project from .exe will automatically closes the console
            // with read code below, it waits to click enter before closing itself
            Console.Read();

            //Note: If this code is executed in MAC, terminal adds
            //"Press any key to continue..." without Read command
        }
    }
}
