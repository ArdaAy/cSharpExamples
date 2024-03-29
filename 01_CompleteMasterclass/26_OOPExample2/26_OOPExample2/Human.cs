﻿using System;
using System.Diagnostics;

namespace _26_OOPExample2
{
    class Human
    {
        // Access Modifiers
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers
        // https://code-maze.com/csharp-access-modifiers/

        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // type prop and click tab button
        public int MyProperty { get; set; }

        // type propfull and click tab button
        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0)
                {
                    age = -value;
                }
                else
                {
                    age = value;
                }
                
            }
        }

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            //this.age = age;
            Age = age;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        // member method
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            else if (age != 0 && lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and {2} years old.", firstName, lastName, age);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}.", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} ", firstName);
            }

        }
        ~Human()
        {
            Debug.Write("The object is destructed");
        }
    }

    
}
