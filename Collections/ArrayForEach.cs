using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayForEach
    {
        private int[] numbers;
        private int size;
        public ArrayForEach (int size) {
            this.size = size;
            this.numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.numbers[i] = i*i;
            }
        }

        public void printArray()
        {
            int counter = 0;
            foreach(int k in numbers)
            {
                Console.WriteLine("Element [{0}] = {1}", counter++, k);
            }
        }
    }
}
