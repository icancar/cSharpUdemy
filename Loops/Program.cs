using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Current value of i is {0}", i);
            }

            for (int i = 0; i <= 20; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            int counter = 0;
            while(counter < 20)
            {
                Console.WriteLine("Value of counter in while loop is: {0}",counter);
                counter++;
            }

            string enteredText = "";
            int counterText = 0;
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Press enter to increase amount by one, or something different to stop!");
                counterText++;
                Console.WriteLine("Current value of counter is {0}", counterText);
                enteredText = Console.ReadLine();
            }

            Console.WriteLine("At the end, value of counter is: {0}", counterText);


            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine("Value of i is: {0}", i);
                if(i ==4)
                {
                    break;
                }
            }
        }
    }
}
