using System;
using System.Collections;

namespace _38_Hashtables
{
    class Program
    {
        // Key - Value
        // Auto - Car

        static Hashtable sHash = new Hashtable();

        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "July", 95);
            Student stud2 = new Student(2, "Dolma", 60);
            Student stud3 = new Student(3, "Cengo", 70);
            Student stud4 = new Student(4, "Lucy", 45);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[stud1.Id];


            // retrieve individual item with known ID
            Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            Console.WriteLine("");

            // retrieve all values from a Hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", temp.Id, temp.Name, temp.GPA);
            }

            Console.WriteLine("");

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", value.Id, value.Name, value.GPA);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            // Challenge:
            /*
             * Write a program that will iterate through each element of the students array and insert them into a hashtable.
             * If a student with the same ID already exists in the hashtable skip it and display the following error:
             * "Sorry, A student with the same ID already exists."
             * Hint: Use the method ContainsKey() to check wether a student with the same ID already exist
             */


            addHashObject(new Student(1, "July", 95));
            addHashObject(new Student(2, "Dolma", 60));
            addHashObject(new Student(3, "Cengo", 70));
            addHashObject(new Student(4, "Lucy", 45));
            //Sorry, A student with the same ID already exists.
            addHashObject(new Student(4, "Ciguli", 99));

            foreach (Student value in sHash.Values)
            {
                Console.WriteLine("Student ID:{0}, Name:{1}, GPA:{2}", value.Id, value.Name, value.GPA);
            }

        }

        static void addHashObject(Student student)
        {
            if (sHash.ContainsKey(student.Id))
            {
                Console.WriteLine("Sorry, A student with the same ID already exists. ID: {0}", student.Id);
            }
            else
            {
                sHash.Add(student.Id, student);
            }
        }
    }


    class Student
    {
        //property called Id
        public int Id { get; set; }

        //property called Name
        public string Name { get; set; }

        //property called GPA
        public float GPA { get; set; }

        //simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
