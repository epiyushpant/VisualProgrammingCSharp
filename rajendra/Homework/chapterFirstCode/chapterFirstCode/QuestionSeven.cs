using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionSeven
    {
        public void seven()
        {
            Console.Write($"Enter Temperature in Fahrenheit : ");
            int f = int.Parse(Console.ReadLine());

            double c = (f - 32) / 1.8;

            Console.WriteLine($"The [{f} deg] is equal to [{c} Cel]");
        }
    }
}
