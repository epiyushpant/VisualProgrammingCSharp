using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionNine
    {

        public void nine()
        {
            Console.Write("Enter number of elements for array size : ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Only positive integer is allowed !");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Invalid input. Enter an integer ! ");
                }
            }

            int largest = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > largest) largest = arr[i];
            }

            Console.WriteLine($"Largest number in the array: {largest}");
        }
    }
}
