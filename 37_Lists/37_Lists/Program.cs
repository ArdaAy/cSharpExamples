using System;
using System.Collections.Generic;

namespace _37_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that returns a list of even integer numbers between 100 and 170 (inclusive).
            
            Console.WriteLine("Hello World!");
            List<int> iList = Solution();

            foreach (int item in iList)
            {
                Console.Write(item  + " ");
            }
        }

        public static List<int> Solution()
        {
            // TODO: write your solution here
            List<int> newList = new List<int>();
            for (var i = 100; i <= 170; i += 2)
            {
                newList.Add(i);
            }
            return newList;
        }
    }
}
