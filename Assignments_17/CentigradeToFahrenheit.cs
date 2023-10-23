using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class CentigradeToFahrenheit
    {
        float c;
        float f;
        public void Display()
        {
            Console.WriteLine("Enter the Body Temperature in Celsius:");
            c = Convert.ToSingle(Console.ReadLine());

            f = c * 9 / 5 + 32;
            Console.WriteLine($"The Body Temperature in Fahrenheit is: {f} F");
        }
    }
}
