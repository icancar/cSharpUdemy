using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("This is an argument, called from method!");

            int number1 = 0;
            int number2 = 5;

            Console.WriteLine("{0} + {1} = {2}", number1, number2, Add(number1, number2));
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from Main Method.");
        }

        public static void WriteSomethingSpecific(string stringToBeWritten)
        {
            Console.WriteLine(stringToBeWritten);
        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
