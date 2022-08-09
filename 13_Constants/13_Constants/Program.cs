using System;

namespace _13_Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants as fields
            const double PI = 3.14159265359;
            const int weeks = 52, months = 12;

            // Create a constant of type string with your birthday as its value
            const string birthday = "21.05.1994";
            const string birthday2 = "05.21.1994";
            const string birthday3 = "2094-05-21";

            static void Main(string[] args)
            {
                Console.WriteLine("My birthday is always going to be: {0}", birthday);
                Console.ReadKey();
            }
        }
    }
}
