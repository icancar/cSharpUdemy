﻿using System;

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
        }
    }
}