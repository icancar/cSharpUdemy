using System;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name and press enter");
            myName = Console.ReadLine();

            Console.WriteLine("My name in lowercase: "+myName.ToLower());
            Console.WriteLine("My name in uppercase: "+myName.ToUpper());
            //clear t
            Console.WriteLine("My name without whitespaces {{0}}",myName.Trim());

            //Challenge 2

            string myString;
            Console.WriteLine("Enter a string here: ");
            myString = Console.ReadLine();
            Console.WriteLine("Enter a character to search:");
            char characterToSearch = (char)Console.Read();
            Console.WriteLine("Index of first occurence of character {0} is {1}", characterToSearch, myString.IndexOf(characterToSearch));




        }
    }
}
