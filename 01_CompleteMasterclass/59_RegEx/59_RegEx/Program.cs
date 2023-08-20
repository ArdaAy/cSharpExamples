using System;
using System.Text.RegularExpressions;

namespace _59_RegEx
{
    class Program
    {
        // https://docs.microsoft.com/tr-tr/dotnet/standard/base-types/regular-expression-language-quick-reference
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference

        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 123456";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found: \n{1}",matchCollection.Count,text);

            foreach (Match match in matchCollection)
            {
                //Console.WriteLine(match);
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}",group[0].Value,group[0].Index);
            }
        }

        //\d\d\d-\d\d\d-\d\d\d\d
        //\d{3}-\d{3}-\d{4}
        //\d{3}.\d{3}.\d{4}
        //\d{3}[-.#]\d{3}[-.#]\d{4}
        //\d{3}[-.#A]\d{3}[-.#]\d{4}

        //(\+49)|0049|0?1(6|7)\d/\d{8}

        //(Mr|Ms)\.?\s[A-Z]{0,10}
        //(Mr|Ms)\.?\s\w+

        //https?://(www.)?tutorials.eu
        //https?://(www.)?(\w+)(\.\w+)

        //\w+@\w+\.\w++

    }
}
