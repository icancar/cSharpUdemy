using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays arrayClass = new Arrays();
            arrayClass.grades[0] = 20;
            arrayClass.grades[1] = 21;
            arrayClass.grades[2] = 22;
            arrayClass.grades[3] = 23;
            arrayClass.grades[4] = 24;

            arrayClass.printGrades();
        }
    }
}
