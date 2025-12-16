using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionFive
    {
        public void five()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
