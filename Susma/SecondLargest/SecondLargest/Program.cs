// Find the second largest in an array
using System;

namespace SecondLargest
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 3, 9, 2, 7 };
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int num in array)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }

            Console.WriteLine("Second Largest Element: " + secondMax);
        }
    }
}

