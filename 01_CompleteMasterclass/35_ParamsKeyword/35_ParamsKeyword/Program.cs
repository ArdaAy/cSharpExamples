using System;

namespace _35_ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 40;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            ParamsMethod2(price, pi, at, book);
            ParamsMethod2("Hi", 5.3, '₺');
            ParamsMethod();

            Console.WriteLine(takeMinValue(1, 4, 5, 6, 7, 4, 7, 8, 9, 12, 43, 54, -5, -11, -55, 34));
        }
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            // for each loop to go through the array of objects
            foreach(object obj in stuff)
            {
                //print each object followed by a space
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int takeMinValue(params int[] numbers)
        {
            if(numbers.Length > 0)
            {
                int min = numbers[0];
                for (int i = 1; i < numbers.Length; i++)
                {
                    min = Math.Min(min, numbers[i]);
                }
                return min;
            }
            else
            {
                return 0;
            }
            
        }
    }

    
}
