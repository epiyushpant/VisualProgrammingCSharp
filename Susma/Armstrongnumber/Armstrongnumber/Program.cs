// C# Program to check wheather a number is an armstrong number.
using System;

namespace Armstrongnumber
{
    class Program
    {
        static void Main(string[] args)
       
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (IsArmstrong(number))
                {
                    Console.WriteLine($"{number} is an Armstrong number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not an Armstrong number.");
                }
            }

            // Function to check if a number is an Armstrong number
            public static bool IsArmstrong(int num)
            {
                int originalNumber = num;
                int sum = 0;
                int numberOfDigits = 0;

                // Count the number of digits
                int temp = num;
                while (temp > 0)
                {
                    temp /= 10;
                    numberOfDigits++;
                }

                // Calculate the sum of the nth powers of each digit
                temp = num;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum += (int)Math.Pow(digit, numberOfDigits);
                    temp /= 10;
                }

                // Check if the sum is equal to the original number
                return sum == originalNumber;
            }
        }
    }
