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
                int currentTemperature;

                if (int.TryParse(Console.ReadLine(), out currentTemperature))
                {
                    Exercise1.CheckIfNumberIsOddOrEven(currentTemperature);
                    switch(currentTemperature)
                    {
                        case 15:
                            Console.WriteLine("Temperature is 15 degrees");
                            break;
                        default:
                            Console.WriteLine("Temperature is different than 15");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ParsingFailed!");
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
