using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("Sum is : " + sum);
            Console.ReadKey();
        }
    }
}
