using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionEleven
    {
        public void eleven()
        {
            Console.Write("Enter value of N: ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N - 1];
            Console.WriteLine($"Enter {N - 1} numbers between 1 and {N}:");

            for (int i = 0; i < N - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            int expectedSum = N * (N + 1) / 2;


            int actualSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                actualSum += arr[i];
            }

            int missingNumber = expectedSum - actualSum;
            Console.WriteLine("Missing number is: " + missingNumber);
        }
    }
}
