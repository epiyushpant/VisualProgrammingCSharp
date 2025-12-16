using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterThirdCode
{
    internal class QuestionOne
    {
        public void one()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Using LINQ query syntax
            var firstThree = (from num in numbers
                              select num).Take(3);

            Console.WriteLine("First 3 elements:");
            foreach (var n in firstThree)
            {
                Console.WriteLine(n);
            }
        }
    }
}
