using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionTwo
    {
        public void swap()
        {
            int i, j;
            Console.WriteLine("|-----------Question No 2------------|");

            Console.Write($"Enter first Number : ");
            i = int.Parse(Console.ReadLine());

            Console.Write($"Enter second Number : ");
            j = int.Parse(Console.ReadLine());

            i = i + j;
            j = i - j;
            i = i - j;

            Console.WriteLine($"Original Value [{i} , {j}] ");
            Console.WriteLine($"After Swap Value [{i} , {j}] ");

        }
    }
}
