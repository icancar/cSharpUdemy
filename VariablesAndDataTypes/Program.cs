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

            Console.WriteLine(myName.ToLower());
            Console.WriteLine(myName.ToUpper());
            //clear t
            Console.WriteLine(myName.Trim());


        }
    }
}
