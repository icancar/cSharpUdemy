using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("This is an argument, called from method!");

            int number1 = 2;
            int number2 = 5;

            Console.WriteLine("{0} + {1} = {2}", number1, number2, Add(number1, number2));
            Console.WriteLine("{0} / {1} = {2}", number1, number2, Divide(number1, number2));

            string friend1 = "Nikola";
            string friend2 = "Igor";
            string friend3 = "Zeliko";

            GreetFriend(friend1);
            GreetFriend(friend2); 
            GreetFriend(friend3);

            Count("Igor is a king.");
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

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hello {0}, my Friend!",friendName);
        }

        public static void Count(string inputString)
        {
            Console.WriteLine("The amount of characters is {0}.",inputString.Length);
        }
    }
}
