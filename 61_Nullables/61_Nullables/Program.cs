using System;

namespace _61_Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;

            int? num2 = 1222;

            double? num3 = new Double?();
            double? num4 = 3.123123;

            bool? boolVal = new bool?();

            Console.WriteLine("Our nullable numbers are: {0},{1},{2},{3}",num1,num2,num3,num4);
            Console.WriteLine("The nullable boolean value is {0}",boolVal);

            bool? isMale = null;
            if(isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if(isMale == false)
            {
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender chosen");
            }

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if(num6 == null)
            {
                num8 = 0.0;
            }
            else
            {
                num8 = (double)num6;
            }

            Console.WriteLine("Value of number8 is: {0}",num8);

            // Shorter: THE NULL COALESCING OPERATOR ??
            // is num6 has a value? if has not, then assign 8.53 to num8
            num8 = num6 ?? 8.53;
            Console.WriteLine("Value of number8 is: {0}", num8);

            // is num7 has a value? if has not, then assign 8.53 to num8 (it has not in this example)
            num8 = num7 ?? 8.53;
            Console.WriteLine("Value of number8 is: {0}", num8);
        }
    }
}
