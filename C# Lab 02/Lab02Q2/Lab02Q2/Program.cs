using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;
            double substraction = num1 - num2;  
            double multiplication = num1 * num2;
            double divition = num1 / num2;

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Substraction is " + substraction);
            Console.WriteLine("Multiplication is " + multiplication);
            Console.WriteLine("Divition is " + divition);

            Console.ReadKey();  

        }
    }
}
