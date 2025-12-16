using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterThirdCode
{
    internal class QuestionTwo
    {
        public void two()
        {
            List<string> words = new List<string> { "apple", "banana", "dog", "strawberry", "cat" };

           
            var longWords = from word in words
                            where word.Length > 5
                            select word;

            Console.WriteLine("Strings longer than 5 characters (query syntax):");
            foreach (var w in longWords)
            {
                Console.WriteLine(w);
            }
        }
    }
}
