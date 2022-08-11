using System;

namespace _19_NestedIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some Booleans
            //Play around with the Values
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            //User-Input
            //Try "Cengiz"
            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            //Code inside will be executed, if isRegistered is true
            if (isRegistered)
            {
                Console.WriteLine("User is registered");

                //Code inside will be executed, if userName is not ""
                if (userName != "")
                {
                    Console.WriteLine("Hello {0}", userName);

                    //Code inside will be executed, if userName is "Cengiz"
                    if (isAdmin)
                    {
                        Console.WriteLine("Admin logged in. Welcome");
                    }
                }
            }

            //The same result can be achieved by using logical and
            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine("Hello {0}", userName);
                Console.WriteLine("Admin logged in. Welcome");

                if (userName == "Cengiz")
                {
                    Console.WriteLine("Welcome, Master Cengiz");
                }
            }

            //This will keep the Console open
            Console.Read();
        }
    }
}
