using System;

namespace _23_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // For Loop example

            for (int cnt = 1; cnt < 20; cnt += 2)
            {
                Console.WriteLine(cnt);
            }
            Console.Read();

            // Do - While Loop Example

            int lenghtOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLenght = nameOfAFriend.Length;
                lenghtOfText += currentLenght;
                wholeText += nameOfAFriend;
            } while (lenghtOfText < 20);
            Console.WriteLine("Thanks, that was enough! " + wholeText);
            Console.Read();

            // While Loop Example

            int counter = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increase amount by one and anything else" +
                    " + enter if you want to finish counting");
                enteredText = Console.ReadLine();

                counter++;
                Console.WriteLine("Current people count is {0}", counter);

            }
            Console.WriteLine("{0} people are inside the bus. Press enter to close the program", counter);
            Console.Read();

            // Continue and Break Example

            for (int cnt = 0; cnt < 20; cnt++)
            {

                if (cnt % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    continue;
                }
                Console.WriteLine(cnt);
                if(cnt == 10)
                {
                    Console.WriteLine("We need to end here.");
                    break;
                }
            }
            Console.Read();
        }
    }
}
