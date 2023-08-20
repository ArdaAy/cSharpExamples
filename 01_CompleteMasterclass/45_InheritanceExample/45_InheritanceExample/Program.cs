using System;

namespace _45_InheritanceExample
{
    class Program
    {
        // Create a main class with the Main method, then a base class employee with the properties Name, 
        // FirstName, Salary and the methods Work() and Pause().
        // Create a deriving class boss with the property CompanyCar and the method Lead().
        // Create another deriving class of employees - trainees with the properties WorkingHours 
        // and SchoolHours and a method Learn();
        // Override the methods Work() of the trainee class so that it indicates 
        // the working hours of the trainee.
        // Don't forget to create the constructors.
        // Create an object of each of the three classes (with arbitrary values) 
        // and call the methods, Lead() of Boss and Work() of Trainee.
        // Just print out the respective text, what the respective employees do.

        static void Main(string[] args)
        {
            Employee cengiz = new Employee("Cengiz", "Patato", 50000);

            cengiz.Work();
            cengiz.Pause();

            Boss talakiFenden = new Boss("Ferrari", "Talaki", "Fenden", 999999999);

            talakiFenden.Lead();

            Trainee ciguli = new Trainee(32, 8, "Ciguli", "Miguel", 10000);
            ciguli.Learn();
            ciguli.Work();
            Console.ReadKey();
        }
    }
}
