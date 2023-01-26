using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("This is an argument, called from method!");
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from Main Method.");
        }

        public static void WriteSomethingSpecific(string stringToBeWritten)
        {
            Console.WriteLine(stringToBeWritten);
        }
    }
}
