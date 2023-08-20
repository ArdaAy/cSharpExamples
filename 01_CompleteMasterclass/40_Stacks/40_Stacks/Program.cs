using System;
using System.Collections.Generic;

namespace _40_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();

            //add elements to the stack using Push()
            stack.Push(1);

            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            stack.Push(2);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            stack.Push(3);
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            Console.WriteLine("Popped item is: {0}", stack.Pop());
            Console.WriteLine("Top value in the stack is: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Popped item is: {0}", stack.Pop());
                Console.WriteLine("Stack Count: {0}", stack.Count);
                
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };

            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("the numbers in the array are:");
            //foreach number in our array
            foreach (int number in numbers)
            {
                //printing
                Console.Write(number + " ");
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse :");
            //as long as our stack is not empty
            while(myStack.Count > 0)
            {
                //Pop it and store it in a variable
                int number = myStack.Pop();
                //print the value we popped
                Console.Write(number + " ");
            }
        }
    }
}
