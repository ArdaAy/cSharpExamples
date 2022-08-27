using System;

namespace _54_Structs
{
    class Program
    {
        
        struct Game
        {
            // interfaces can be added
            // inheritance does not allowed

            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            // Empty (default) constructors cannot be used for a struct
            /*
            public Game() {
                this.name = "";
                this.developer = "";
                this.rating = 0;
                this.releaseDate = "";
            }
            */
            public Game(string name, string developer, double rating, string releaseDate)
            {
                this.name = name;
                this.developer = developer;
                this.rating = rating;
                this.releaseDate = releaseDate;
            }

            public void Display()
            {
                Console.WriteLine("Game1's name is: {0}", name);
                Console.WriteLine("Game1 was developed by {0}", developer);
                Console.WriteLine("Game1's rating is: {0}", rating);
                Console.WriteLine("Game1 was released in {0}", releaseDate);
            }
        }

        static void Main(string[] args)
        {
            Game game1;

            

            game1.name = "Pokemon Go";
            game1.developer = "Niantic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";
            /*
            Console.WriteLine("Game1's name is: {0}",game1.name);
            Console.WriteLine("Game1 was developed by {0}",game1.developer);
            Console.WriteLine("Game1's rating is: {0}",game1.rating);
            Console.WriteLine("Game1 was released in {0}",game1.releaseDate);
            */

            game1.Display();
        }

    }
}
