namespace C_Basics.Oop.Polymorphism
{
   public class OperatorOverloadingDemo
    {
        public static void GetOperatorOverloadingDemo()
        {
            MyString str1 = new MyString("Hello, ");
            MyString str2 = new MyString("World!");

            MyString result = str1 + str2;

            Console.WriteLine($"String 1: {str1}");
            Console.WriteLine($"String 2: {str2}");
            Console.WriteLine($"Result of concatenation with custom format: {result}");
        }

        public static void GetComplexNumber()
        {

            Complex c1 = new Complex(5, 4);
            Complex c2 = new Complex(2, 3);

            Complex sum = c1 + c2;   // Calls overloaded +
            Complex diff = c1 - c2;  // Calls overloaded -
            bool equal = c1 == c2;   // Calls overloaded ==
            bool notequal = c1 != c2; // Calls overloaded !=

            Console.WriteLine("First Complex Number: ");
            c1.Display();
            Console.WriteLine("Second Complex Number: ");
            c2.Display();

            Console.WriteLine("\nSum: ");
            sum.Display();
            Console.WriteLine("Difference: ");
            diff.Display();

            Console.WriteLine($"\nAre both equal? {equal}");
            Console.WriteLine($"Are both not equal? {notequal}");
        }
}
}
