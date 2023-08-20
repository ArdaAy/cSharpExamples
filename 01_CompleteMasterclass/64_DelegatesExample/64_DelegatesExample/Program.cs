using System;

namespace _64_DelegatesExample
{
    /*
     * Create a public delegate that will be called OperationDelegate and will get two arguments with float type and return float as well;
     * 
     * Create 4 static public methods called Add, Subtract, Multiply, and Divide. 
     * All of them should get 2 arguments and return a float that corresponds to the result of the performed operation;
     * 
     * Create ApplyOperation method that gets 2 floats and one delegate and applies the operation to those values;
     */
    
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ApplyOperation(10, 5, Add);
            ApplyOperation(10, 5, Subtract);
            ApplyOperation(10, 5, Multiply);
            ApplyOperation(10, 5, Divide);
            */
            Console.WriteLine(ApplyOperation(10, 5, Add));
            Console.WriteLine(ApplyOperation(10, 5, Subtract));
            Console.WriteLine(ApplyOperation(10, 5, Multiply));
            Console.WriteLine(ApplyOperation(10, 5, Divide));
        }

        public static float ApplyOperation(float num1, float num2, OperationDelegate od)
        {
            return od(num1, num2);
        }

        /*
        public static void ApplyOperation(float num1, float num2, OperationDelegate od)
        {
            Console.WriteLine(od(num1, num2));
        }
        */
        public delegate float OperationDelegate(float num1, float num2);

        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public static float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
