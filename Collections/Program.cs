using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();

            matrix.initializeMatrix();

            matrix.printMatrix();
            int[] studentGrades = new int[] { 2, 2, 33, 4, 5 };
            Console.WriteLine("AverageValue of array is: {0}", getAverageValue(studentGrades));

        }

        static double getAverageValue(int[] gradesArray)
        {
            double sum = 0;
            for(int i = 0; i< gradesArray.Length; i++)
            {
                sum += gradesArray[i];
            }

            return (double)sum/gradesArray.Length;
        }
    }
}
