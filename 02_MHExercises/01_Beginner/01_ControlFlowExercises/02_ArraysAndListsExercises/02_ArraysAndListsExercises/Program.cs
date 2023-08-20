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

        static void Exercise03()
        {

        }
    }

    
}
