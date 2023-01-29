using System;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter temperature!");
                int currentTemperature = int.Parse(Console.ReadLine());

                if (currentTemperature <= 10)
                {
                    Console.WriteLine("It's so cold!");
                }
                else if (currentTemperature >= 11 && currentTemperature <= 20)
                {
                    Console.WriteLine("It's little bit warmer!");
                }
                else
                {
                    Console.WriteLine("It's so warm outside!");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Please enter temperature in numbers!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected exception!");
            }
           
        }
    }
}
