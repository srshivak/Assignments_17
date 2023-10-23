using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_17
{
    internal class Vowels
    {
        public void Display()
        {
            Console.Write("Enter an alphabet:");
            char input = char.Parse(Console.ReadLine());
            if (IsVowel(input))
            {
                Console.WriteLine($"{input} is a vowel");
            }
            else
            {
                Console.WriteLine($"{input} is not a vowel");
            }
            static bool IsVowel(char c)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                c = char.ToLower(c);
                foreach (char vowel in vowels)
                {
                    if (c == vowel)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
