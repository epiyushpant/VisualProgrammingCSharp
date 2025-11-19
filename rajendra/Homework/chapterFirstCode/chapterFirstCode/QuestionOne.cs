using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionOne
    {

        public void swap()
        {
            int i, j;

            Console.Write($"Enter first Number : ");
            i = int.Parse(Console.ReadLine());

            Console.Write($"Enter second Number : ");
            j = int.Parse(Console.ReadLine());

            int temp = i;
            i = j;
            j = temp;

            Console.WriteLine($"Original Value [{i} , {j}] ");
            Console.WriteLine($"After Swap Value [{i} , {j}] ");

        }
    }
}
