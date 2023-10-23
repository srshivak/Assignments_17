using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    public class ArithmeticOps
    {
        float num1;
        float num2;
        public void GetData()
        {
            Console.WriteLine("Enter the First Number:");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            num2 = Convert.ToSingle(Console.ReadLine());
        }

        public void Calculation()
        {
            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Substraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
        }
    }
}
