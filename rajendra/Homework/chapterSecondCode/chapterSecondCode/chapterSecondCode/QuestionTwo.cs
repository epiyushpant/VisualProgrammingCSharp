using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionTwo
    {
        public void two()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool isDuplicate = false;

                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result = result + input[i];
                }
            }

            Console.WriteLine("String after removing duplicates: " + result);
        }
    }
}
