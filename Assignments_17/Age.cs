using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class Age
    {
        public void Display()
        {
            Console.WriteLine("Enter your age:");

            int age = Convert.ToInt32(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

        }
        
    }
}
