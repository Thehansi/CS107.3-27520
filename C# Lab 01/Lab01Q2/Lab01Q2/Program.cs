﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI*radius*radius;

            Console.WriteLine("The area of the circle is {0}", area);
            Console.ReadLine(); 

        }
    }
}
