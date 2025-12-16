using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionFour
    {
        public void four()
        {
            List<int> data = new List<int> { 1, 2, -3, 4 };

            bool anyNegativeNumber = data.Any(n => n < 0);

            Console.WriteLine(anyNegativeNumber);

        }
    }
}
