using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee's salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the tax rate: (In decimal format)");
            double tax = Convert.ToDouble(Console.ReadLine());

            double taxAmount = salary * tax;
            double newsalary = salary - taxAmount;

            Console.WriteLine("New salary:" + newsalary);
            Console.ReadKey();

        }
    }
}
