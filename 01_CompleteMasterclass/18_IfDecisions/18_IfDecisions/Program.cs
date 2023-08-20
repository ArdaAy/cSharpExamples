using System;

namespace _18_IfDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            
            int numTemp, number;
            
            if(int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number, 0 set as temperature.");
            }

            if (numTemp < 20)
            {
                Console.WriteLine("Take the coat");
            }else if (numTemp == 20)
            {
                Console.WriteLine("Pants and Pull Over should be fine");
            }else if (numTemp > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }

            Console.Read();
        }
    }
}
