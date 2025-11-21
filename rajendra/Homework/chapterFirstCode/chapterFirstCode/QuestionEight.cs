using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionEight
    {
        static int Fib(int n)
        {
            if (n <= 1)
                return n;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void eight()
        {
            Console.Write($"Enter number of terms: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Fibonacci Series:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fib(i) + " ");
            }
        }
    }
}
