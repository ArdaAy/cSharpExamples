using System;
using System.IO;

namespace _53_FileIOExample
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            // Example 1 - reading Text
            string text = File.ReadAllText(@"C:\Users\ardaa\Desktop\textFile.txt");

            Console.WriteLine("Textfile contains following text:\n{0}", text);
            Console.WriteLine("");
            
            // Example 2 - reading text
            string[] lines = File.ReadAllLines(@"C:\Users\ardaa\Desktop\textFile.txt");

            Console.WriteLine("Contents of textfile.txt");
            foreach (string str in lines)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            // Example 3 - Writing text and reads it
            string[] linesArr = { "First Line", "Second Line", "Third Line" };

            // it creates a file if does not exists
            File.WriteAllLines(@"C:\Users\ardaa\Desktop\textFileNew.txt", linesArr);

            string[] lastLines = File.ReadAllLines(@"C:\Users\ardaa\Desktop\textFile.txt");

            Console.WriteLine("Contents of new textfile.txt");
            foreach (string str in lastLines)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("");

            // Example 4 - Creating a new text file with a given name and writes the text into

            Console.WriteLine("Give a name to the file:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter the text that will be written into the file:");
            string input = Console.ReadLine();
            
            File.WriteAllText(@"C:\Users\ardaa\Desktop\"+ fileName+".txt", input);
            */
            // Example 5

            string[] lines = File.ReadAllLines(@"C:\Users\ardaa\Desktop\textFile.txt");
            using (StreamWriter file = new StreamWriter(@"C:\Users\ardaa\Desktop\myText.txt"))
            {
                foreach(string line in lines)
                {
                    file.WriteLine(line);
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\ardaa\Desktop\myText.txt",true))
            {
                file.WriteLine("Additional Line");
            }
        }
    }
}
