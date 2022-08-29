using System;
using System.Collections.Generic;

namespace _65_LambdaExample
{
    /*
     * Subject:

        Create a dictionary that will contain <string, Func<>> pairs. The keys will be operation signs "+", "-", "/", "*" and values 
        will be the lambda expressions that will perform the corresponding operation on two floats and return a result with type float.

        One more time in detail:

        Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.

        You can store function as follow:

        static Func<int, int> Name = (a) => a;

        Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.

        Example: {"sign", Function}

        Create a static method OperationGet that will get as input a string, test if this string is a Key in the dictionary and if positive return function otherwise returns null.
     */
    class Program
    {
        public static Func<float, float, float> Plus = (float a, float b) => a + b;

        public static Func<float, float, float> Minus = (float a, float b) => a - b;

        public static Func<float, float, float> Divide = (float a, float b) => a / b;

        public static Func<float, float, float> Multiply = (float a, float b) => a * b;

        public static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>()
        {
            { "+", Plus},
            { "-", Minus},
            { "/", Divide},
            { "*", Multiply}

        };

        public static Func<float, float, float> OperationGet(string s)
        {

            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }

        static void Main(string[] args)
        {
            // Plus
            Console.WriteLine(OperationGet("+")(5,8));

            // Minus
            Console.WriteLine(OperationGet("-")(8, 5));

            // Divide
            Console.WriteLine(OperationGet("/")(10, 2));

            // Multiply
            Console.WriteLine(OperationGet("*")(5, 8));

            // null
            Func<float, float, float> func = OperationGet("");
            if(func != null)
            {
                Console.WriteLine(func(3,5));
            }
            else
            {
                Console.WriteLine("Null Func!");
            }
            
        }
    }
}
