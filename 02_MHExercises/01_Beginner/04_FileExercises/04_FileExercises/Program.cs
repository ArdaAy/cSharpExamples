using System;
using System.IO;
using System.Text;

namespace _04_FileExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise01();
            //Exercise02();
        }

        /* Exercise01
         * Write a program that reads a text file and displays the number of words.
         */
        static void Exercise01()
        {
            //string text = File.ReadAllText(@"c:\file.txt", Encoding.UTF8);

            string[] lines = File.ReadAllLines(@"c:\file.txt", Encoding.UTF8);

            var cnt = 0;
            foreach (var item in lines)
            {
                var split = item.Split(" ");
                cnt += split.Length;
            }

            Console.WriteLine("Number of words is {0}", cnt);
        }

        static void Exercise02()
        {
            string[] lines = File.ReadAllLines(@"c:\file.txt", Encoding.UTF8);

            var longestStr = "";
            foreach (var item in lines)
            {
                var split = item.Split(" ");
                foreach (var word in split)
                {
                    if (longestStr.Length < word.Length)
                    {
                        longestStr = word;
                    }
                }
                
            }
            Console.WriteLine("The longest word in the text file is {0}",longestStr);
        }
    }
}
