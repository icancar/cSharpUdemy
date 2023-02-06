using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Arrays
    {
        //declare array of int
        public int[] grades = new int[5];

        public void printGrades()
        {
            Console.WriteLine("Grades at index 0: {0}", this.grades[0]);
            Console.WriteLine("Grades at index 1: {0}", this.grades[1]);
            Console.WriteLine("Grades at index 2: {0}", this.grades[2]);
            Console.WriteLine("Grades at index 3: {0}", this.grades[3]);
            Console.WriteLine("Grades at index 4: {0}", this.grades[4]);
        }
    }
}
