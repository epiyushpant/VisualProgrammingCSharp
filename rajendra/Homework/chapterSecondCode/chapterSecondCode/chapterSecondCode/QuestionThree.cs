using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionThree
    {
        public void three()
        {
            List<string> words = new List<string> { "apple", "dog", "banana" };

            words.Sort((a, b) => a.Length.CompareTo(b.Length));

        }
    }
}
