using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionTen
    {
        public void ten()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            int count = 0;
            foreach (char ch in input)
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("Number of vowels: " + count);
        }
    }
}
