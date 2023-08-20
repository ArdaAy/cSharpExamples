using System;

namespace _55_Enums
{
    class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};

        enum Month { Jan = 5, Feb, Mar, Apr, May, Jun, Jul = 15, Aug, Sep, Oct, Nov, Dec};
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine(fr == a);

            Console.WriteLine((int) Month.Feb);
            Console.WriteLine((int) Month.Jan);

            Console.WriteLine((int) Month.Aug);
        }
    }
}
