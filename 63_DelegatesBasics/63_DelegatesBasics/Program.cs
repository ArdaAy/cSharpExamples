using System;
using System.Collections.Generic;

namespace _63_DelegatesBasics
{
    class Program
    {
        // defining a delegate type called FilterDelegate that takes a
        // person object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args)
        {
            // Example 1
            /*
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("-----before-----");
            //print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // calling RemoveAll and passing a method filter we created

            names.RemoveAll(Filter);

            Console.WriteLine("-----after-----");
            // print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            // Example 2
            // Create 4 person objects
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to a list called people
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            Console.WriteLine();
            DisplayPeople("Adults", people, IsAdult);
            Console.WriteLine();
            DisplayPeople("Seniors", people, IsSenior);


            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            Console.WriteLine();
            DisplayPeople("Kids", people, filter);

            Console.WriteLine();
            foreach (Person p in people)
            {
                if (filter(p))
                {
                    Console.WriteLine(p.Name);
                }
            }

            Console.WriteLine();

            // Anonymous Method Usage
            DisplayPeople("All: ", people, delegate (Person p) { return true; });


        }

        // a method to display the list of people that passes the filter condition (returns true)
        // this method will take a little to be displayed, the list of people, and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            // print the title
            Console.WriteLine(title);

            foreach (Person p in people)
            {
                // check if this person passes the filter
                if (filter(p))
                {
                    // print the person's name and age
                    Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
                }
            }
        }

        static bool Filter(string s)
        {
            // return whether the string s contains the letter 'i'
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }

        //==========FILTERS================

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }

        //=================================
    }
}
