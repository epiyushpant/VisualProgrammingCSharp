namespace C_Basics.ExceptionHandlingDemo
{
    internal class DemoExceptionHandling
    {

        public static void LearnExceptionHandling()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                string userInput = Console.ReadLine();

                // Attempt to parse the input as an integer
                int number = int.Parse(userInput);
                Console.WriteLine($"You entered: {number}");
 
                // Simulate a division operation
                int result = 100 / number;
                Console.WriteLine($"100 divided by {number} is: {result}");
            }
            catch (FormatException ex)
            {
                // Handle invalid input that can't be parsed to an integer
                Console.WriteLine("Error: Please enter a valid number.");
                Console.WriteLine($"Details: {ex.Message}");
            }  
            catch (DivideByZeroException ex)
            {
                // Handle division by zero
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any other unhandled exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            finally
            {
                // Code in the finally block always executes
                Console.WriteLine("Thank you for using the application.");
            }
        }


        public static void NullReferenceExceptionHandling()
        {
            try
            {
                string str = null;
                // This will throw a NullReferenceException
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Caught a NullReferenceException.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }

        public static void IndexOutOfRangeExceptionHandling()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                // This will throw an IndexOutOfRangeException
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught an IndexOutOfRangeException.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }

        public static void DivideByZeroExceptionHandling()
        {
            try
            {
                int numerator = 10;
                int denominator = 0;
                // This will throw a DivideByZeroException
                //int result = numerator / denominator;

                int[] numbers = { 1, 2, 3 };
                // This will throw an IndexOutOfRangeException
                Console.WriteLine(numbers[5]);

                //Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught a DivideByZeroException.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }


        public static void FormatExceptionHandling()
        {
            try
            {
                string invalidNumber = "abc";
                // This will throw a FormatException
                int number = int.Parse(invalidNumber);
                Console.WriteLine($"Parsed number: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Caught a FormatException.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }

        public static void OverflowExceptionHandling()
        {
            try
            {
                // This will throw an OverflowException
                int maxInt = int.MaxValue;
                int overflowedInt = checked(maxInt + 1);
                Console.WriteLine($"Overflowed Int: {overflowedInt}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Caught an OverflowException.");
                Console.WriteLine($"Details: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }
    }
}
