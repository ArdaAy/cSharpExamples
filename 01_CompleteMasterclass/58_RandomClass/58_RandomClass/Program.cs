using System;

namespace _58_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random dice = new Random();
            int numEyes;

            for (int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);
            }
            */

            Random yesNoMaybe = new Random();
            int answerNum = yesNoMaybe.Next(1, 4);

            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            }
            else if(answerNum == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
