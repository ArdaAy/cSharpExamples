using System;

namespace _10_ConsoleChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and surname (no middle name)");
            //Ciguli Miguli
            string text = Console.ReadLine();

            // Ciguli
            string name = text.Split(" ")[0];

            //Miguli
            string surname = text.Split(" ")[1];

            //Your name is Ciguli
            Console.WriteLine("Your name is " + name);

            //Your surname is Miguli
            Console.WriteLine("Your surname is " + surname);

            //Replace example: CiguliMiguli
            Console.WriteLine("Replace ' ' example: " + text.Replace(" ", ""));

            //Uppercase example: CİGULİ
            Console.WriteLine("Uppercase example: " + name.ToUpper());

            //lovercase example: ciguli
            Console.WriteLine("lovercase example: " + name.ToLower());

            //Substring (1) example: iguli
            Console.WriteLine("Substring (1) example: " + name.Substring(1));

            //Substring (2) example: guli
            Console.WriteLine("Substring (2) example: " + name.Substring(2));

        }
    }
}