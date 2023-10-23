using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class GreatestOfTwo
    {
        public void Display()
        {
            Console.Write("Enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            int max = (num1 > num2) ? num1 : num2;
            Console.WriteLine($"The greatest number is: {max}");
        }
    }
}
