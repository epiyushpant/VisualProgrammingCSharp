using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Swapprogram2
{
        public class Program
        {
            public static void Main()
            {
                int number1 = 30, number2 = 40;
                Console.WriteLine($"Before SWapping number1= {number1}, number2 = {number2}");
                number1 = number1 + number2; //number1=70(30+40)      
                number2 = number1 - number2; //number2=30(70-40)      
                number1 = number1 - number2; //number1=40(70-30)    
                Console.WriteLine($"After swapping number1= {number1}, number2 = {number2}");
                Console.ReadKey();
            }
        }
  
    }