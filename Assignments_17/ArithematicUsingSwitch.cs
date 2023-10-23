using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    public class ArithematicUsingSwitch
    {
        float a;
        float b;
        int num;

        public void GetData()
        {
            Console.WriteLine("Enter the First Number:");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            b = Convert.ToSingle(Console.ReadLine());
        }
        public void Menu()
        {
            Console.WriteLine("Choose Your Arithematic operation:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
        }

        public void UserChoise()
        {
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine($"{a}+{b} = {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"{a}-{b} = {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"{a}*{b} = {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"{a}/{b} = {a / b}");
                    break;
                default:
                    Console.WriteLine("Wrong Choise! Please Choose from the Menu.");
                    break;
            }
        }
       
    }
}
