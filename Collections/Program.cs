using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,String> dictionary = new Dictionary<int,String>();

            dictionary.Add(1, "Igor");
            dictionary.Add(2, "Nikola");
            dictionary.Add(3, "Zeliko");

            Console.WriteLine(dictionary.ToString());

        }
    }
}
