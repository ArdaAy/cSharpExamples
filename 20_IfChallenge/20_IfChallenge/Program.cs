using System;
using System.Collections.Generic;
namespace _20_IfChallenge
{
    class Program
    {
        public static List<User> uList = new List<User>();

        static void Main(string[] args)
        {
            int selection = 0;
            bool login = false;

            while(selection != -1)
            {
                if(selection == 0)
                {
                    Console.WriteLine("Type the number of the function you want to use below");
                    Console.WriteLine("(1) Register");
                    Console.WriteLine("(2) Login");
                    Console.WriteLine("(-1) Exit");
                    int.TryParse(Console.ReadLine(), out selection);
                }
                else if(selection == 1)
                {
                    Console.WriteLine("Enter your new username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your new password");
                    string password = Console.ReadLine();

                    bool isRegistered = registerNewUser(username, password);
                    if (isRegistered)
                    {
                        Console.WriteLine("Your registration is completed successfuly. You can login now.");
                        selection = 0;
                    }
                    else
                    {
                        Console.WriteLine("Your registration is not completed because username is used already. Please try another username.");
                    }
                }
                else if(selection == 2)
                {
                    Console.WriteLine("Enter your username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string password = Console.ReadLine();

                    bool isLoggedIn = loggingIn(username, password);
                    if (isLoggedIn)
                    {
                        Console.WriteLine("You have logged in successfuly.");
                        Console.WriteLine("Hello {0}, welcome", username);
                        selection = 4;
                        Console.WriteLine("Type the number of the function you want to use below");
                        Console.WriteLine("(5) Log Out");
                        Console.WriteLine("(-1) Exit");
                        int.TryParse(Console.ReadLine(), out selection);
                    }
                    else
                    {
                        Console.WriteLine("Username or/and password is wrong.");
                    }
                }
                else if (selection == 4)
                {
                    Console.WriteLine("Type the number of the function you want to use below");
                    Console.WriteLine("(5) Log Out");
                    Console.WriteLine("(-1) Exit");
                    int.TryParse(Console.ReadLine(), out selection);
                }
                else if(selection == 5)
                {
                    Console.WriteLine("Logging out now...");
                    selection = 0;
                }
                else if (selection == -1)
                {
                    Console.WriteLine("The Program ends now.");
                }
            }
        }

        public static bool loggingIn(string username, string password)
        {
            bool isThere = false;
            for (int i = 0; i < uList.Count; i++)
            {
                if (username.Equals(uList[i].userName) && password.Equals(uList[i].password))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool registerNewUser(string username, string password)
        {
            bool isThere = false;
            for(int i = 0; i < uList.Count; i++)
            {
                if (username.Equals(uList[i].userName))
                {
                    isThere = true;
                }
            }
            if (!isThere)
            {
                uList.Add(new User(username, password));
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class User
    {
        public string userName;
        public string password;

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
