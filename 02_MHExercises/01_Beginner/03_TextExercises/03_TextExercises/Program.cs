using System;

namespace _03_TextExercises
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
        }

        /* Exercise01
         * Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * Work out if the numbers are consecutive. 
         * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
         */
        static void Exercise01()
        {
            Console.WriteLine("Enter few mumbers seperated by a hyphen (e.g. '1-2-3-4-5')");
            var input = Console.ReadLine();

            var split = input.Split("-");

            var intArr = Array.ConvertAll(split, int.Parse);

            var consecutive = true;
            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i - 1] + 1 != intArr[i])
                    consecutive = false;
            }

            if(consecutive)
                Console.WriteLine("This list is consecutive");
            else
            {
                consecutive = true;
                for (int i = 1; i < intArr.Length; i++)
                {
                    if (intArr[i] + 1 != intArr[i - 1])
                        consecutive = false;
                }
                if (consecutive)
                    Console.WriteLine("This list is consecutive");
                else
                    Console.WriteLine("This list is not consecutive");
            }
        }

        /* Exercise02
         * Write a program and ask the user to enter a few numbers separated by a hyphen. 
         * If the user simply presses Enter, without supplying an input, exit immediately; 
         * otherwise, check to see if there are duplicates. 
         * If so, display "Duplicate" on the console.
         */
        static void Exercise02()
        {
            Console.WriteLine("Enter few mumbers seperated by a hyphen (e.g. '1-2-3-4-5')");
            Console.WriteLine("If you want to quit, simply click enter");

            while (true)
            {
                var input = Console.ReadLine();
                var split = input.Split("-");
                var nList = Array.ConvertAll(split, int.Parse);

                var dub = false;
                for (int i = 0; i < nList.Length; i++)
                {
                    for (int j = 0; j < nList.Length; j++)
                    {
                        if (i != j)
                        {
                            if (nList[i] == nList[j])
                            {
                                dub = true;
                                break;
                            }
                        }
                    }
                    if (dub)
                        break;
                }

                if(dub)
                    Console.WriteLine("There is dublication");
                else
                    Console.WriteLine("There is no dublication");

            }
        }

        /* Exercise03
         * Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
         * A valid time should be between 00:00 and 23:59. 
         * If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
         * If the user doesn't provide any values, consider it as invalid time.
         */
        static void Exercise03()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();

            var timeSplit = input.Split(":");
            var intArr = Array.ConvertAll(timeSplit, int.Parse);

            var valid = true;
            if(intArr[0] < 0 || intArr[0] > 23 || intArr[1] < 0 || intArr[1] > 59)
                valid = false;
            
            if(valid)
                Console.WriteLine("Time is valid");
            else
                Console.WriteLine("Time is invalid");
        }

        /* Exercise04
         * Write a program and ask the user to enter a few words separated by a space. 
         * Use the words to create a variable name with PascalCase. 
         * For example, if the user types: "number of students", display "NumberOfStudents". 
         * Make sure that the program is not dependent on the input. 
         * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
         */
        static void Exercise04()
        {
            Console.WriteLine("Enter some words seperated with space");
            var input = Console.ReadLine();


            var split = input.Split(" ");
            var join = "";

            foreach (var item in split)
            {
                var newItem = item.ToLower();
                join += newItem.Substring(0, 1).ToUpper() + newItem.Substring(1);
            }
            Console.WriteLine(join);
            
        }

        /* Exercise05
         * Write a program and ask the user to enter an English word. 
         * Count the number of vowels (a, e, o, u, i) in the word. 
         * So, if the user enters "inadequate", the program should display 6 on the console.
         */
        static void Exercise05()
        {
            Console.WriteLine("Write a word");
            var input = Console.ReadLine().ToLower();
            var vovelCnt = 0;
            foreach (var item in input)
            {
                if (item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i')
                    vovelCnt++;
            }
            Console.WriteLine("Vovel count is {0}",vovelCnt);
        }
    }
}
