using System;

namespace _04_PrimitiveDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types
            // Integral

            // signed byte -> range from -128 - 127
            sbyte sb = 1;

            // short -> range from -32,768 - 32,767
            short s = 1;

            // integer -> range from -2,147,483,648 - 2,147,483,647
            int i = 1;

            // long -> range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long l = 1;

            // Choose the smallest type your value fits into.

            // Floating point

            // float -> range from 1.5 × 10 ^−45 - 3.4 × 10 ^ 38, 7 - digit precision
            float f = 0.5f;

            // double -> range from 5.0 × 10 ^−324 - 1.7 × 10 ^ 308, 15 - digit precision
            double d = 0.5;

            // decimal -> range from –7.9 × 10 ^−28 - 7.9 × 10 ^ 28, 28 - digit precision
            decimal de = 0.5m;

            // Use float for 3D graphics, double for everything (except money calculations) and
            // decimal for financial applications.

            //Boolean

            bool bo = true;

            //Use a boolean if you want to set something to true or false(just like a toggle).

            //Unicode characters and strings
            
            char c = 'A';

            // string is not a primitive data type, it is a class
            string name = "John Doe";

            //Use a string for a path, username, birthdate...

        }
    }
}
