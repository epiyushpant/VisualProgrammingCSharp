namespace chapterSecondCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("Please Enter the Question Number [1-6 which question you want to run] :");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Question One \n Write a C# program to reverse a string entered by the user.");
                    QuestionOne q1 = new QuestionOne();
                    q1.one();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 2:
                    Console.WriteLine("Question Two \n Write a C# program to remove duplicate characters from a string.");
                    QuestionTwo q2 = new QuestionTwo();
                    q2.two();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 3:
                    Console.WriteLine("Question Three \n Write a lambda expression to sort strings by length.");
                    QuestionThree q3 = new QuestionThree();
                    q3.three();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 4:
                    Console.WriteLine("Question Four \n Write a lambda expression to check for negative numbers.");
                    QuestionFour q4 = new QuestionFour();
                    q4.four();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 5:
                    Console.WriteLine("Question Five \n Write a lambda expression to filter even numbers from a list.");
                    QuestionFive q5 = new QuestionFive();
                    q5.five();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    goto start;

                case 6:
                    Console.WriteLine("Question Six \n Write a lambda expression to check if a string starts with 'A'.");
                  QuestionSix q6 = new QuestionSix();
                    q6.six();
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
