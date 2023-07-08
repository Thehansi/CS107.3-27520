using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i<10; i++)
            {
                Console.WriteLine("Enter num {0}:", i);
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
                Console.ReadKey();
            }
        }
    }
}
