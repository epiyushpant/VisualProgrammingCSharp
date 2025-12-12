using System.Collections.Specialized;

namespace Chapter3_4
{
    internal class LINQExample
    {
        //write basic linq queries to exaplain linq 

        public static void LINQPrintNumbers()
        {
            //Query Syntax 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // LINQ query to get even numbers

            //var evenNumber = new List<int>();

            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evenNumber.Add(num);
            //    }
            //}

            //Console.WriteLine("evenNmbers", evenNumber);
            //Console.ReadKey();

            //var evenNumbers = from num in numbers
            //                  where num % 2 == 0
            //                  select num;
            //Console.WriteLine("Even Numbers:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Method Syntax 
            // LINQ method syntax to get odd numbers
            var oddNumbers = numbers.Where(num => num>5);


            Console.WriteLine("Odd Numbers:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void LinQPrintGreaterThanFive()
        {
            //Query Syntax 
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // LINQ query to get numbers greater than 5
            var greaterThanFive = from num in numbers
                                  where num > 5
                                  select num;
            Console.WriteLine("Numbers greater than 5:");
            foreach (var number in greaterThanFive)
            {
                Console.WriteLine(number);
            }

            //Query Syntax

            // LINQ method syntax to get numbers less than or equal to 5

            var lessThanOrEqualToFive = numbers.Where(num => num <= 5);
            Console.WriteLine("Numbers less than or equal to 5:");

        }

        public static void LINQPrintNames()
        {
            //Query Syntax 
            List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
            // LINQ query to get names ends with 'A'
            var aNames = from name in names
                         where name.EndsWith("a")
                         select name;
            Console.WriteLine("Names starting with A:");
            foreach (var name in aNames)
            {
                Console.WriteLine(name);
            }

        }

    }
}
