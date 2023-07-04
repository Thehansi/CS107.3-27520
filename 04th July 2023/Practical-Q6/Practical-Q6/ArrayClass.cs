using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Q6
{
    internal class ArrayClass
    {
        public int[] CreateArray(int size)
        {
            int[] array = new int[size * 2];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter value {i + 1}:");
                int userInput = Convert.ToInt32(Console.ReadLine());

                array[i * 2] = userInput;
                array[i * 2 + 1] = 0;
            }
            return array;
        }
    }
}
            

