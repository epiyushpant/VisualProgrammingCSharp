namespace C_Basics.Operators
{
    public class LearnOperators
    {

        /// <summary>
        /// This is a  class for learning operators 
        /// </summary>
        /// <remarks>
        /// This example shows how to use operatiors in c# 
        /// </remarks>


        public static void GetOperatorsExercise()
        {
            ///This is my console app 
            Console.WriteLine("Please enter first number!");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second  number!");
            int secondNumber = int.Parse(Console.ReadLine());

            //int addedNumber = firstNumber + secondNumber;
            //Console.WriteLine("Addition : " + addedNumber);

            //int subtrationNumber = firstNumber - secondNumber;
            //Console.WriteLine($"Subtraction: {subtrationNumber}");

            //int multiplication = firstNumber * secondNumber;
            //Console.WriteLine($"multiplication:{multiplication}");

            //int division = firstNumber / secondNumber;
            //Console.WriteLine($"division:{division}");

            //int modulus = firstNumber / secondNumber;
            //Console.WriteLine($"modulus:{modulus}");


            int thirdNum = firstNumber++; //20 retutn 20 , thirdNUm = 20 , firstNumber =21 
            int fifthNum = ++firstNumber; // fifthNum = 21 , firstNumber = 21 

            firstNumber++;
            int fourthNum = firstNumber; 

           // Console.WriteLine($"increment:{firstNumber++}"); // 2o return then increase to 21 
            Console.WriteLine($"increment:{++firstNumber}"); // increase 20 to 21 then return 
            //Console.WriteLine(firstNumber);

            //Console.WriteLine($"increment:{--secondNumber}"); 
            Console.ReadKey();
        }

        public static void GetOperatorsExerciseSecond()
        {
            ///This is my console app 
            Console.WriteLine("Please enter first number!");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second  number!");
            int secondNumber = int.Parse(Console.ReadLine());


            //Reltional operator 

            //Console.WriteLine($"First number > Second number: {firstNumber > secondNumber}");
            ////complete code 


            ////Logical operators 

            //bool bothGreaterThan10 = (firstNumber > 10) && (secondNumber > 10);
            //Console.WriteLine($"Both numbers are greater than 10: {bothGreaterThan10}");

            //complete remaining code 

            Console.ReadKey();
        }
    }
}

