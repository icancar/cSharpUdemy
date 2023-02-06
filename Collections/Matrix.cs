using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Matrix
    {
        public int[,] array2D = new int[3,3];

        public void initializeMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    this.array2D[i,j] = i * j;
                }
            }
        }

        public void printMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0}]", array2D[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
