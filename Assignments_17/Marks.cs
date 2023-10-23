using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class Marks
    {
        public void Display()
        {
            Console.WriteLine("Enter ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter marks for 5 subjects:");
            int totalmarks = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Subject {i} marks:");
                int subjectMarks = Convert.ToInt32(Console.ReadLine());
                totalmarks += subjectMarks;
            }

            double average = totalmarks / 5.0;
            Console.WriteLine($"TotalMarks:{totalmarks}");
            Console.WriteLine($"Average marks:{average}");


            if (average >= 80 && average <= 100)
            {
                Console.WriteLine("Grade: First Grade");
            }
            else if (average >= 60 && average <= 80)
            {
                Console.WriteLine("Grade: Second Grade");
            }
            else if (average >= 30 && average < 60)
            {
                Console.WriteLine("Grade: Third Grade");
            }
            else
            {
                Console.WriteLine("Grades: Fail");
            }
        }
    }
}
