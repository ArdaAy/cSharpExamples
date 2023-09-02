using System;

namespace _03_StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            bool IsProgramWorking = true;

            while (IsProgramWorking)
            {
                ActionPrinter();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        AddStackItem(stack);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        stack.PrintStack();
                        break;
                    case "4":
                        stack.Clear();
                        break;
                    case "5":
                        Console.WriteLine("Quiting...");
                        IsProgramWorking = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AddStackItem(Stack stack)
        {
            Console.WriteLine("Give the value that you want to add to stack");
            var val = Console.ReadLine();
            stack.Push(val);
        }


        public static void ActionPrinter()
        {
            Console.WriteLine("Select Action Below");
            Console.WriteLine("1-Push item");
            Console.WriteLine("2-Pop item");
            Console.WriteLine("3-Print stack");
            Console.WriteLine("4-Clear stack");
            Console.WriteLine("5-Quit");
        }
    }
}
