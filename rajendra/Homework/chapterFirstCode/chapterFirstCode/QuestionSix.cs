using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionSix
    {

        public void six()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int originalNum = num;
            int digits = 0;
            int temp = num;

            // Count digits
            while (temp != 0)
            {
                temp /= 10;
                digits++;
            }

            temp = num;
            double result = 0;


            while (temp != 0)
            {
                int remainder = temp % 10;
                result += Math.Pow(remainder, digits);
                temp /= 10;
            }

            if (result == originalNum)
                Console.WriteLine($"{originalNum} is an Armstrong number.");
            else
                Console.WriteLine($"{originalNum} is not an Armstrong number.");
        }
    }
}
