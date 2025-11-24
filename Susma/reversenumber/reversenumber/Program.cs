
// Reverse Program
using System;
namespace reversenumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            int remainder, revnumber = 0;
            while(number > 0)
            {
                remainder = number % 10;
                remainder = number / 10;
                revnumber = (revnumber * 10) + remainder;
            }
            Console.Write("Reverse Number is {}:", revnumber);

        }
    }
}
