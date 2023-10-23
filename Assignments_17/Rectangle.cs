using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class Rectangle
    {
        public void Display()
        {
            Console.WriteLine("Enter length: ");

            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            if (length == breadth)
            {
                Console.WriteLine("It is a square");
            }
            else
            {
                Console.WriteLine(" It is a rectangle");
            }
        }
    }
}
