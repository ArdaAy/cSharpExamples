using System;
using System.Collections.Generic;
using System.IO;

namespace _57_ParsingGame
{
    class Program
    {
        /*
         * The rules:

            Create a class Program with the Main method with code that will read from the input.txt line by line;

            If one of the lines contains "split", you have to split it (use the split method from string class)

            Take the return from the split and write the element with index 4 into the output.txt ;

            You have to add a space between each element to make it readable;
        */
        static void Main(string[] args)
        {
            //C:\Users\ardaa\Desktop\C#\input.txt
            string[] lines = File.ReadAllLines(@"C:\Users\ardaa\Desktop\C#\input.txt");

            List<string> linesToWrite = new List<string>();
            foreach (string line in lines)
            {
                if (line.Contains("split"))
                {
                    string[] splitedLine = line.Split();
                    
                    linesToWrite.Add(splitedLine[4]);
                    
                    
                }
            }

            foreach (string item in linesToWrite)
            {
                Console.Write(item+" ");
            }
            
            using (StreamWriter file = new StreamWriter(@"C:\Users\ardaa\Desktop\C#\output.txt"))
            {
                foreach (string item in linesToWrite)
                {
                    file.Write(item +" ");
                }
            }
        }
    }
}
