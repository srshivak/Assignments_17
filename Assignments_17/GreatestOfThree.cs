using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    public class GreatestOfThree
    {
        int a;
        int b;
        int c;
        public void Display()
        {
            Console.Write("Enter the First number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("a is the Geatest Number.");
            }
            else if(b>a && b > c)
            {
                Console.WriteLine("b is the Geatest Number.");
            }
            else
            {
                Console.WriteLine("c is the Geatest Number.");
            }
        }
    }
}
