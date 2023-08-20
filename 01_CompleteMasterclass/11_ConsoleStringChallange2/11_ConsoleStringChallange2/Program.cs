using System;

namespace _11_ConsoleStringChallange2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test string here
            Console.WriteLine("Enter a string here:");
            string str = Console.ReadLine();

            //s
            Console.WriteLine("Enter the character to search:");
            string ch = Console.ReadLine();
            //string ch = Console.ReadLine()[0];

            while (ch.Length > 1)
            {
                Console.WriteLine("You need to enter just one charater.");
                Console.WriteLine("Enter the character to search:");
                ch = Console.ReadLine();
            }

            //Character found in the text at 2 index first
            if (str.IndexOf(ch) >= 0)
            {
                Console.WriteLine("Character found in the text at "+ str.IndexOf(ch)+" index first");
            }
            
            // Ciguli
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            //Miguli
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            //Your name and surname is Ciguli Miguli
            Console.WriteLine("Your name and surname is {0} {1}", name, surname);

            Console.WriteLine("Your name and surname is " + string.Concat(name, " ", surname) );
        }
    }
}
