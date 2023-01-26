using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from Main Method.");
            Console.Read();
        }
    }
}
