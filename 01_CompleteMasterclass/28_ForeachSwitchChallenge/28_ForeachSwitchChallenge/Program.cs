using System;

namespace _28_ForeachSwitchChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean valid = false;
            string inputValueType;

            Console.Write("Enter a value : ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter : ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                case 1:
                    // check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    // check for string
                    valid = IsAllNumeric(inputValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    // check for string
                    valid = IsBool(inputValue);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "";
                    break;
            }

            if(inputValueType != "")
            {
                if (valid)
                {
                    Console.WriteLine("It is a valid :" + inputValueType);
                }
                else
                {
                    Console.WriteLine("It is a invalid :" + inputValueType);
                }
            }
            else
            {
                Console.WriteLine("Input Value Type selection error!");
            }
            

        }

        /// <summary>
        /// Method to check if the input string is a pure letter
        /// </summary>
        static bool IsAllAlphabetic(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Method to check if the input string is a pure number
        /// </summary>
        static bool IsAllNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsNumber(c))
                {   
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Method to check if the input string is a boolean (typed as a string)
        /// </summary>
        static bool IsBool(string value)
        {
            if(value.ToLower() == "true" || value.ToLower() == "false")
            {
                return true;
            }
            return false;
        }
    }
}
