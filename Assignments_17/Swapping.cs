using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class Swapping
    {
        public void Show()
        {
            Console.Write("Enter the first value");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping: a={a},b={b}");
            a = a + b; 
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping: a={a},b={b}");
        }
        
    }
}
