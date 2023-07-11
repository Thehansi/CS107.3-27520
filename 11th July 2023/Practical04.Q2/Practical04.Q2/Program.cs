using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical04.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmaticCalcuator calculator = new ArithmaticCalcuator();

            calculator.Number1 = 20;
            calculator.Number2 = 6;

            int sum = calculator.Add();
            int difference = calculator.Subtract();
            int product = calculator.Multiply();
            double quotient = calculator.Divide();

            Console.WriteLine("Sum is : " + sum);
            Console.WriteLine("Difference is : " + difference);
            Console.WriteLine("Product is : " + product);
            Console.WriteLine("Quotient is : " + quotient);

            Console.ReadLine();
        }
    }


}
    

