using System;

namespace _24_LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalScore = 0;
            int scoreCnt = 0;
            
            do
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Enter a new score (must be between 0 - 20), \nCurrently count: {0}, Currently Total: {1}", scoreCnt, totalScore);
                int score = -1;
                bool isParsed = int.TryParse(Console.ReadLine(), out score);
                if (isParsed)
                {
                    if(score == -1)
                    {
                        break;
                    }
                    else if(score >= 0 && score <= 20)
                    {
                        totalScore += score;
                        scoreCnt++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                }
                else
                {
                    Console.WriteLine("You typed wrong score. Try again.");
                }

            } while (true);

            double average = (double)totalScore / (double)scoreCnt;
            Console.WriteLine("Currently count: {0}, Currently Total: {1}", scoreCnt, totalScore);
            Console.WriteLine("Average: "+ average);
        }
    }
}
