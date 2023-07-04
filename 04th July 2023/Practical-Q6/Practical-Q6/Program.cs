using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            ArrayClass obj1 = new ArrayClass();
            int[] result = obj1.CreateArray(size);

            Console.WriteLine("Array with alternating user inputs and 0s:");
            foreach (int value in result)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();
        }
    }
}
