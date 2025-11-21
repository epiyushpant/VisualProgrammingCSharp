using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterFirstCode
{
    internal class QuestionThree
    {

        public void prime()
        {
            int i;

            Console.Write($"Enter a Number to Check Prime of Not : ");
            i = int.Parse(Console.ReadLine());

            if (i <= 1)
                Console.WriteLine($" [{i}] is Not Prime Number !");
            else
            {
                for (int x = 2; x <= i * i; x++)  
                {
                    if (i % x == 0)
                    {

                        Console.WriteLine($" [{i}] is Not Prime Number !");

                        break;
                        
                    }
                }

                Console.WriteLine($" [{i}] is Prime Number !");

            }




        }
    }
}
