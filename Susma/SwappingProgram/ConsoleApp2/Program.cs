using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;


class Program
    {
        static void Main()
        {
            int a = 20, b = 50, temp;

            Console.WriteLine("Before swap: a = " + a + ", b = " + b);

            temp = a;  // store value of a
            a = b;     // assign b to a
            b = temp;  // assign temp (old a) to b

            Console.WriteLine("After swap: a = " + a + ", b = " + b);
        }
    }       
