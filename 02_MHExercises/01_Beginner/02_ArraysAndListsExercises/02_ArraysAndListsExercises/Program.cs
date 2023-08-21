using System;
using System.Collections.Generic;

namespace _02_ArraysAndListsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            Exercise05();
        }

        /* Exercise01
         * When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
         * If no one likes your post, it doesn't display anything.
         * If only one person likes your post, it displays: [Friend's Name] likes your post.
         * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
         * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
         * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
         * Depending on the number of names provided, display a message based on the above pattern.
         */
        static void Exercise01()
        {
            Console.WriteLine("Give a name (or press enter for next step)");
            var nList = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input != "")
                    nList.Add(input);
                else
                    break;
            }

            if(nList.Count == 1)
                Console.WriteLine("{0} likes your post.", nList[0]);
            else if(nList.Count == 2)
                Console.WriteLine("{0} and {1} like your post.", nList[0], nList[1]);
            else if (nList.Count > 3)
                Console.WriteLine("{0}, {1} and {2} others like your post.", nList[0], nList[1], (nList.Count-2));
        }

        /* Exercise02
         * Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
         */
        static void Exercise02()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();

            Array.Reverse(nameArray);

            string revName = "";
            foreach (char item in nameArray)
            {
                revName += item;
            }

            Console.WriteLine("The reversed name is {0}",revName);
        }

        /* Exercise03
         * Write a program and ask the user to enter 5 numbers. 
         * If a number has been previously entered, display an error message and ask the user to re-try. 
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        static void Exercise03()
        {
            var list = new List<int>();
            Console.WriteLine("Enter 5 unique numbers");
            while (list.Count < 5)
            {
                var input = int.Parse(Console.ReadLine());
                var isThere = false;
                foreach (var item in list)
                {
                    if (item == input)
                        isThere = true;
                }
                if (!isThere)
                    list.Add(input);
                else
                    Console.WriteLine("The number {0} is existing in the list. Please enter a unique number",input);
            }
            var nList = list.ToArray();

            Array.Sort(nList);

            Console.WriteLine("The sorted list is");
            foreach (var item in nList)
            {
                Console.WriteLine(item);
            }
        }

        /* Exercise04
         * Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates. 
         * Display the unique numbers that the user has entered.
         */
        static void Exercise04()
        {
            Console.WriteLine("Enter a list of numbers one by one (Type 'Quit' to stop entering)");
            var nList = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit" || input == "quit" || input == "")
                    break;
                nList.Add(int.Parse(input));
            }

            var nUniqueList = new List<int>();
            foreach (var item1 in nList)
            {
                var isThere = false;
                foreach (var item2 in nUniqueList)
                {
                    if (item1 == item2)
                        isThere = true;
                }
                if (!isThere)
                    nUniqueList.Add(item1);
            }

            Console.WriteLine("The unique list is");
            foreach (var item in nUniqueList)
            {
                Console.WriteLine(item);
            }
        }

        /*
         * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
         * otherwise, display the 3 smallest numbers in the list.
         */
        static void Exercise05()
        {
            Console.WriteLine("Enter a list of comma seperated numbers more than or equal 5 items (e.g '5,1,9,2,10')");

            string[] splitArray;

            while (true)
            {
                var input = Console.ReadLine();
                splitArray = input.Split(",");
                if (splitArray.Length < 5)
                    Console.WriteLine("Invalid List. There is no 5 numbers in the list. Please enter again");
                else
                    break;
            }

            Console.WriteLine("The three smallest numbers in the list are");

            var nList = Array.ConvertAll(splitArray, int.Parse);
            Array.Sort(nList);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nList[i]);
            }


        }

    }

    
}
