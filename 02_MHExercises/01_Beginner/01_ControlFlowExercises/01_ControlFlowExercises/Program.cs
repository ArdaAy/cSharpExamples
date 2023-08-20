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
            //Exercise05();
            //Exercise06();
            //Exercise07();
            //Exercise08();
            Exercise09();
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

        /* Exercise05
         * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
         * Display the count on the console.
         */
        static void Exercise05()
        {
            int cnt = 0;
            int maxNumber = 100;
            for (int i = 1; i < maxNumber; i++)
            {
                if (i % 3 == 0)
                    cnt++;
            }
            Console.WriteLine("The count of the numbers between 1 and 100 are divisible by 3 with no remainder is {0}",cnt);
        }

        /* Exercise06
         * Write a program and continuously ask the user to enter a number or "ok" to exit. 
         * Calculate the sum of all the previously entered numbers and display it on the console.
         */
        static void Exercise06()
        {
            var total = 0;
            while (true)
            {
                Console.WriteLine("Enter a number to sum (Enter 'ok' if you are done)");
                var enteredValue = Console.ReadLine();
                if (enteredValue == "ok")
                    break;
                else
                    total += int.Parse(enteredValue);
            }
            Console.WriteLine("Sum of the given numbers is {0}",total);
        }

        /* Exercise07
         * Write a program and ask the user to enter a number. 
         * Compute the factorial of the number and print it on the console. 
         * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
         */
        static void Exercise07()
        {
            Console.WriteLine("Enter a number to take factorial value");
            var number = int.Parse(Console.ReadLine());
            var total = 1;
            for (int i = 1; i <= number; i++)
            {
                total *= i;
            }
            Console.WriteLine("Calculated facrotial number is {0}",total);
        }

        /* Exercise08
         * Write a program that picks a random number between 1 and 10. 
         * Give the user 4 chances to guess the number. 
         * If the user guesses the number, display “You won"; otherwise, display “You lost". 
         * (To make sure the program is behaving correctly, you can display the secret number on the console first.)
         */
        static void Exercise08()
        {
            var randomNumber = new Random().Next(1,10);
            Console.WriteLine("Number is {0}",randomNumber);
            var cnt = 0;
            while(cnt < 4)
            {
                Console.WriteLine("Make a guess");
                var guess = int.Parse(Console.ReadLine());
                if (guess == randomNumber)
                {
                    Console.WriteLine("You Won!");
                    break;
                }
                else
                    Console.WriteLine("Try Again");
                cnt++;
                if(cnt == 4)
                    Console.WriteLine("You lost");
            }
        }

        /* Exercise09
         * Write a program and ask the user to enter a series of numbers separated by comma. 
         * Find the maximum of the numbers and display it on the console. 
         * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
         */
        static void Exercise09()
        {
            Console.WriteLine("Enter series of numbers separated by comma (For Example '1,2,3,4')");
            var numberSeries = Console.ReadLine();
            var splitedStr =  numberSeries.Split(",");
            var numbers = Array.ConvertAll(splitedStr, int.Parse);

            if(numbers.Length > 0)
            {
                int selectedNumber = numbers[0];
                for(var i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] > selectedNumber)
                        selectedNumber = numbers[i];
                }

                Console.WriteLine("Max number in the series is {0}", selectedNumber);
            }
            else
                Console.WriteLine("Please enter more than one number");
        }
    }
}
