using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionOne
    {
        public void one () {
            Console.Write("Enter a string: ");
            string userInput = Console.ReadLine();

            string reversed = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversed = reversed + userInput[i];
            }

            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
