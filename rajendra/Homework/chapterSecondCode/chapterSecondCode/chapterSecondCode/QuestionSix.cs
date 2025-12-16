using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterSecondCode
{
    internal class QuestionSix
    {
        public void six()
        {
            Func<string, bool> startsWithA = s => s.StartsWith("A");

            Console.WriteLine(startsWithA("Apple"));   
            Console.WriteLine(startsWithA("Banana"));  

        }
    }
}
