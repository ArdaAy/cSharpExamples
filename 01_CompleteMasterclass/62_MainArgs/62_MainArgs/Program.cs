using System;

namespace _62_MainArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            // The args array cannot be null. So, it's safe to access the Length property without null checking
            // so we check the length of the array if it's zero it means no arguments were provided to the application
            if(args.Length == 0)
            {
                Console.WriteLine("This is a smart app that uses args ;) Please provide arguments next time ");
                Console.WriteLine("Pass Help if you need more details");
                return;
            }
            else if(args[0] == "Help")
            {
                // display manual
                Console.WriteLine("*******************Instructions");
                Console.WriteLine("* use one of the following commands followed by 2 numbers");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'sub' : to substract 2 numbers");
            }
            else if (args[0] == "add" || args[0] == "sub")
            {
                Console.WriteLine("Type first number");
                string str1 = Console.ReadLine();

                Console.WriteLine("Type second number");
                string str2 = Console.ReadLine();

                //int num1, num2;

                if (int.TryParse(str1, out int num1) && int.TryParse(str2, out int num2))
                {
                    if (args[0] == "add")
                    {
                        Console.WriteLine("Addition of {0} and {1} is: {2}", num1, num2, (num1 + num2));
                    }
                    else
                    {
                        Console.WriteLine("Substraction of {0} from {1} is: {2}", num2, num1, (num1 - num2));
                    }
                }
                else
                {
                    Console.WriteLine("Your all entiries are not in the digit format!");
                }
            }
            else
            {
                Console.WriteLine("Wrong Command");
                Console.WriteLine("Pass Help if you need more details");
            }
            
        }
    }
}
