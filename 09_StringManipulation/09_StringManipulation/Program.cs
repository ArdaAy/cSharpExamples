using System;

namespace _09_StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Class
            // https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netcore-3.1

            // define few variables
            int age = 28;
            string name = "Dolmaci";
            string job = "Developer";

            // 1. String Concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");

            // 2. String Formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old, I'm a {2}",name,age,job);

            // 3. String Interpolation
            // string interpollation uses $ at the start which will allow us to write our 
            // variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old, I'm a {job}");

            // 4. Verbatim Strings
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
            Nunc feugiat egestas leo, non mattis nunc tincidunt sit amet.
            Etiam cursus quam nec sapien aliquam rhoncus.Duis ipsum dui, pretium non leo vitae, ultrices blandit nunc. 
            Morbi sollicitudin, quam nec accumsan congue, ligula nunc sodales tellus, vitae malesuada nunc ipsum nec neque.
            Quisque faucibus quis nisl at sagittis. 
            Curabitur fermentum dui dolor, sed euismod dolor scelerisque vel.");

            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U, \A and \D are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Hahaha \n you have no powers here!");

            Console.WriteLine("Ouch! \nyou have powers here!");

        }
    }
}
