using System;
using System.Collections.Generic;
using System.Linq;

namespace _39_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one"},
                { 2, "two"},
                { 3, "three"}
            };

            Employee[] employees =
            {
                new Employee("CEO", "Dolma",28,200),
                new Employee("Manager","July", 26,150),
                new Employee("Security","Cengo",10,100),
                new Employee("Runner","Lucy",12,50)
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            string key = "CEO";
            if (employeesDirectory.ContainsKey(key))
            {
                Employee emp1 = employeesDirectory["CEO"];
                Console.WriteLine("Employee Name: {0}, Role: {1}, Salary: {2}", emp1.Name, emp1.Role, emp1.Salary);
            }
            else
            {
                Console.WriteLine("The key {0} does not exists", key);
            }
            Console.WriteLine("");
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to returnt the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                // print the key
                Console.WriteLine("Key: {0}, i is {1}", keyValuePair.Key, i);

                // storing the value in an employee object
                Employee employeeValue = keyValuePair.Value;

                // printring the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);
                Console.WriteLine("");
            }

        }
    }

    class Employee
    {
        //few properties like Role Name, Age and Rate

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly Salary = rate / h * number of days * number of weeks * number of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
