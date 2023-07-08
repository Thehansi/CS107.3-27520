using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of the circle: ");
            double radius = -Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("Area is : " + area);
            Console.WriteLine("Circumferemce is " + circumference);

            Console.ReadLine();
        }
    }
}
