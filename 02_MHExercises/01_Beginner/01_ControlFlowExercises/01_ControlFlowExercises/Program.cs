using System;

namespace _01_ControlFlowExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
        }

        /* Exercise01
         * Write a program and ask the user to enter a number. 
         * The number should be between 1 to 10. 
         * If the user enters a valid number, display "Valid" on the console. 
         * Otherwise, display "Invalid".
         */
        static void Exercise01()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Enter a number between 1 and 10");
                number = int.Parse(Console.ReadLine());

                // using Console.Read() for getting int value work for one time, then never gets another value again.

                if (number >= 1 && number <= 10)
                    break;
                else
                    Console.WriteLine("You have entered a wrong number");

            }
            Console.WriteLine("The number that you entered is {0}", number);
        }

        /* Exercise02
         * Write a program which takes two numbers from the console and displays the maximum of the two.
         */
        static void Exercise02()
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());

            if (num1>num2)
                Console.WriteLine("First number ({0}) is bigger than the second number ({1})",num1,num2);
            else
                Console.WriteLine("Second number ({0}) is bigger than the first number ({1})",num2,num1);
        }

        /* Exercise03
         * Write a program and ask the user to enter the width and height of an image. 
         * Then tell if the image is landscape or portrait.
         */
        static void Exercise03()
        {
            Console.WriteLine("Enter width of the image");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of the image");
            int height = int.Parse(Console.ReadLine());

            if(width> height)
                Console.WriteLine("The image is landscape");
            else
                Console.WriteLine("The image is portrait");
        }

        /* Exercise04
         * Your job is to write a program for a speed camera. 
         * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
         * Write a program that asks the user to enter the speed limit. 
         * Once set, the program asks for the speed of a car. 
         * If the user enters a value less than the speed limit, program should display Ok on the console. 
         * If the value is above the speed limit, the program should calculate the number of demerit points. 
         * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
         * If the number of demerit points is above 12, the program should display License Suspended.
         */
        static void Exercise04()
        {
            Console.WriteLine("Enter speed limit");
            int speedLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter speed of a car");
            int speedOfCar = int.Parse(Console.ReadLine());

            if(speedOfCar < speedLimit)
                Console.WriteLine("OK");
            else
            {
                int speedDifference = speedOfCar - speedLimit;
                int demeritPoint = speedDifference / 5;
                if(demeritPoint > 12)
                    Console.WriteLine("License Suspended. Demerit Point is {0}", demeritPoint);
                else
                    Console.WriteLine("Demerit Point is {0}", demeritPoint);
            }
        }
    }
}
