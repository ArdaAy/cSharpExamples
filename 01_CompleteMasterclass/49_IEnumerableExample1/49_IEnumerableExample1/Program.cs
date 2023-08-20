using System;
using System.Collections.Generic;

namespace _49_IEnumerableExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a generic IEnumerable variable that takes any collection of type int
            // we will use this variable to store the collections that will get returned by the GetCollection() method

            IEnumerable<int> unknownCollection;

            Console.WriteLine("This was a List<int>");
            unknownCollection = GetCollection(1);

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nThis was a Queue<int>");

            unknownCollection = GetCollection(2);

            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nThis was a int[]");

            unknownCollection = GetCollection(3);
            
            foreach (int num in unknownCollection)
            {
                Console.Write(num + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // create a list of numbers and initialize it
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            
            // add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            // if the option is 1
            if(option == 1)
            {
                // return the list of type List<int>
                return numbersList;
            } // if the option is 2
            else if(option == 2)
            {
                // return the queue of type<int>
                return numbersQueue;
            }
            else
            {
                // return an array of numbers initialized with some numbers
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
