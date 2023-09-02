using System;
using System.Collections.Generic;

namespace _02_StackOverflowPostExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> pList = new List<Post>();
            bool ProgramRunning = true;

            while (ProgramRunning)
            {
                ActionPrinter();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        pList.Add(CreatePost(pList.Count));
                        break;
                    case "2":
                        PrintPosts(pList);
                        break;
                    case "3":
                        Vote(pList, 0);
                        break;
                    case "4":
                        Vote(pList, 1);
                        break;
                    case "5":
                        Console.WriteLine("Quiting...");
                        ProgramRunning = false;
                        break;
                    default:
                        break;
                }
            }

        }

        private static void Vote(List<Post> list, int selection)
        {
            Console.WriteLine("Type the ID of the post (type -1 to cancel)");
            var strId = Console.ReadLine();
            var id = -1;
            var canBeParsed = int.TryParse(strId, out id);
            
            if (!canBeParsed)
            {
                Console.WriteLine("Given ID must be in number format");
                return;
            }
            else if(list.Count - 1< id)
            {
                Console.WriteLine("Given ID wrong.");
                return;
            }
            else if (id == -1)
            {
                Console.WriteLine("Voting cancelled.");
                return;
            }

            if (selection == 0)
                list[id].UpVote();
            else if (selection == 1)
                list[id].DownVote();
        }

        private static void PrintPosts(List<Post> list)
        {
            if(list.Count == 0)
                Console.WriteLine("There is no post in the list.");
            else
            {
                foreach (var post in list)
                {
                    Console.WriteLine("\n"+post.ToString());
                }
                Console.WriteLine();
            }
        }

        public static Post CreatePost(int Id)
        {
            Console.WriteLine("Write author of the post");
            var author = Console.ReadLine();

            Console.WriteLine("Write title of the post");
            var title = Console.ReadLine();

            Console.WriteLine("Write description of the post");
            var description = Console.ReadLine();

            return new Post(Id, title, description, author);

        }

        public static void ActionPrinter()
        {
            Console.WriteLine("Select Action Below");
            Console.WriteLine("1-Add new post");
            Console.WriteLine("2-See all posts");
            Console.WriteLine("3-Up Vote a post");
            Console.WriteLine("4-Down Vote a post");
            Console.WriteLine("5-Quit");
        }
    }
}
