using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionFour
    {
        public void four()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (long.TryParse(input, out long number))
            {
                string reversed = ReverseString(input);

                if (input == reversed)
                {
                    Console.WriteLine($"{number} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
