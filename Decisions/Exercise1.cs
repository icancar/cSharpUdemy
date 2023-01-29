using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Exercise1
    {
        public static void CheckIfNumberIsOddOrEven(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("Number {0} is Even", number);
            }
            else
            {
                Console.WriteLine("Number {0} is Odd", number);
            }
        }
    }
}
