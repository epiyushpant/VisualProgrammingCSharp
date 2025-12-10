namespace C_Basics.Oop.Polymorphism
{

    public class MethodOverloadingDemo
    {
        // Method overloading for adding two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method overloading for adding three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method overloading for adding two double values
        public double Add(double a, double b)
        {
            return a + b;
        }

        public static void  CallCalculator()
        {
            MethodOverloadingDemo calculator = new MethodOverloadingDemo();

            Console.WriteLine(calculator.Add(2, 3));         // Outputs 5 (int, int)
            Console.WriteLine(calculator.Add(2, 3, 4));      // Outputs 9 (int, int, int)
            Console.WriteLine(calculator.Add(2.5, 3.5));     // Outputs 6.0 (double, double)
        }
    }

  

}
