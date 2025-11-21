namespace chapterFirstCode
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("Please Enter the Question Number [1-11 which question you want to run] :");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Question One \n Write a C# program to swap two numbers using a third variable.");
                    QuestionOne one = new QuestionOne();
                    one.swap();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 2:
                    Console.WriteLine("Question Two \n Write a C# program to swap two numbers without using a third variable.");
                    QuestionTwo two = new QuestionTwo();
                    two.swap();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 3:
                    Console.WriteLine("Question Three \n Write a C# program to input a number from the user and check if it is a prime number.");
                    QuestionThree three = new QuestionThree();
                    three.prime();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 4:
                    Console.WriteLine("Question Four \n Write a C# program that checks whether a number is a palindrome.");
                    QuestionFour four = new QuestionFour();
                    four.four();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 5:
                    Console.WriteLine("Question Five \n Write a C# program to reverse a number entered from the console.");
                    QuestionFive five = new QuestionFive();
                    five.five();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 6:
                    Console.WriteLine("Question Six \n Write a C# program to check whether a number is an Armstrong number.");
                    QuestionSix six = new QuestionSix();
                    six.six();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 7:
                    Console.WriteLine("Question Seven \n Write a C# program to convert temperature from Fahrenheit to Celsius.");
                    QuestionSeven seven = new QuestionSeven();
                    seven.seven();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 8:
                    Console.WriteLine("Question Eight \n Write a C# program to print the first N numbers of the Fibonacci series using recursion.");
                    QuestionEight eight = new QuestionEight();
                    eight.eight();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 9:
                    Console.WriteLine("Question Nine \n Write a C# program to find the second largest number in an array.");
                    QuestionNine nine = new QuestionNine();
                    nine.nine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 10:
                    Console.WriteLine("Question Ten \n Write a C# program to count the number of vowels (a, e, i, o, u) in a given string.");
                    QuestionTen ten = new QuestionTen();
                    ten.ten();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 11:
                    Console.WriteLine("Question Eleven \n Write a C# program to find the missing number in an array of integers from 1 to N.");
                    QuestionEleven q = new QuestionEleven();
                    q.eleven();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                default:
                    Console.WriteLine("Invalid question number");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;
            }
        }
    }
}