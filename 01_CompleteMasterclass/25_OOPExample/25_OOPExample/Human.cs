using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOPExample
{
    class Human
    {
        // why private? https://softwareengineering.stackexchange.com/questions/143736/why-do-we-need-private-variables
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;
        private bool isHuman = true;

        public Human(int theAge, string firstName, string lastName, string eyeColor)
        {
            age = theAge;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(int theAge, string firstName, string eyeColor)
        {
            age = theAge;
            this.firstName = firstName;
            this.lastName = "";
            this.eyeColor = eyeColor;
        }


        public void IntroduceOnceself()
        {
            if(age == 1)
            {
                Console.WriteLine("My name is {0} {1}, I'm {2} year old. My eye color is {3}", firstName, lastName, age, eyeColor);
            }
            else
            {
                Console.WriteLine("My name is {0} {1}, I'm {2} years old. My eye color is {3}", firstName, lastName, age, eyeColor);
            }
        }
    }
}
