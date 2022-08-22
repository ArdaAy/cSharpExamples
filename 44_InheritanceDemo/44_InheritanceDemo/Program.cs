using System;

namespace _44_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Cengiz");
            Console.WriteLine(post1.ToString());

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Cengiz",
                "https://images.com/shoes", true);

            Console.WriteLine(imagePost1.ToString());
        }
    }
}
