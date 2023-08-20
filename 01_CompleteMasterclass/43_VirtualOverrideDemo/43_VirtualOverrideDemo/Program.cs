using System;

namespace _43_VirtualOverrideDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Cabbar", 10);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
