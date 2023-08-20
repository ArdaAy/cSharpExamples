using System;
using System.Collections;
using System.Collections.Generic;

namespace _48_IEnumeratorAndIEnumerableDemo
{
    class Program
    {
        // 1. IEnumerable<T> for generic collections
        // 2. IEnumerable for non generic collections

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> object.
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a Current property that points at the object we are currently at in the collection
        /// </summary>
        /// 

        // When it is recommended to use the IEnumerable interface:
        // - Your collection represents a massive database table
        // you don't want to copy the entire thing into memory and cause performance issues in your application.

        // When it is not recommended to use IEnumerable interface:
        // - You need the results right away and are possibly mutating / editing the objects later on.
        // In this case, it is better to use Array or a List.



        static void Main(string[] args)
        {
            DogShelter dogShelter = new DogShelter();

            foreach (Dog dog in dogShelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
                
            }

        }

        class Dog
        {
            // the name of the dog
            public string Name { get; set; }

            // is this a naughty dog
            public bool IsNaughtyDog { get; set; }

            public Dog(string name, bool isNaughtyDog)
            {
                this.Name = name;
                this.IsNaughtyDog = isNaughtyDog;
            }

            // this method will print how many treats the dog received
            public void GiveTreat(int numberOfTreats)
            {
                // print a message containing the number of treats and the name of the dog
                Console.WriteLine("Dog: {0} said wuoff {1} times!.", Name, numberOfTreats);
            }
        }

        // a class named DogShelter
        // this class contains a generic collection of type Dog
        // objects of this class can't be used inside a for each loop because it lacks an implementation of the IEnumerable interface
        class DogShelter : IEnumerable<Dog>
        {
            // list of type List<Dog>
            public List<Dog> dogs;

            //this constructor will initialize the dogs list with some values
            public DogShelter()
            {
                dogs = new List<Dog>()
                {
                    new Dog("Cabbar", false),
                    new Dog("Oreo", true),
                    new Dog("Cengiz", false),
                    new Dog("Pabuc", false),
                };
            }

            IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
            {
                return dogs.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
    }
}
