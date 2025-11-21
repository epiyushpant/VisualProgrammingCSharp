using System;

namespace chapterFirstCode
{
    internal class QuestionThree
    {
        public void prime()
        {
            Console.Write("Enter a Number to Check Prime or Not: ");
            int i = int.Parse(Console.ReadLine());

            if (i <= 1)
            {
                Console.WriteLine($"[{i}] is Not a Prime Number!");
                return;
            }

            bool isPrime = true;

            
            for (int x = 2; x * x <= i; x++)
            {
                if (i % x == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine($"[{i}] is a Prime Number!");
            else
                Console.WriteLine($"[{i}] is Not a Prime Number!");
        }
    }
}
