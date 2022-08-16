using System;

namespace _30_NestedForLoopsWith2DArrays
{
    class Program
    {

        static int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        static void Main(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("");

            //Nested For loop Example 1
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
                
            }

            Console.WriteLine("");

            for (int i = 0, j = 2; i < matrix.GetLength(0); i++,j--)
            {
                Console.WriteLine(matrix[i, j]);
            }

            Console.WriteLine("");

            //Nested For loop Diagonal Example 2
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
