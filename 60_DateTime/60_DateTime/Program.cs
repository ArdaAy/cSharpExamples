using System;

namespace _60_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1994, 5, 2);

            Console.WriteLine("My Birthday is {0}", dateTime);

            

            //double day = milli / 24 / 60 / 60 / 1000;

            Console.WriteLine(DateTime.Today);

            Console.WriteLine(DateTime.Now);

            Console.WriteLine(GetTomorrow());


            Console.WriteLine(DateTime.Today.DayOfWeek);

            Console.WriteLine(GetFirstDayOfYear(1997).DayOfWeek);

            int days = DateTime.DaysInMonth(1994, 5);

            Console.WriteLine("Days in May 1994: {0}",days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute: {0}",now.Minute);

            // Display the time in this structure x o'clock y minutes and z seconds

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            Console.WriteLine("Write your birth date in this format: yyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", daysPassed.Days);
            }

        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
