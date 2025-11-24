
// Checking vowel 
using System;
using System.Linq; // like a count function

namespace vowelscount
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            int vowelCount = CountVowels(inputString);

            Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
        }

        public static int CountVowels(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }

            // Convert the string to lowercase to handle both uppercase and lowercase vowels
            string lowerCaseText = text.ToLower();

            // Define the set of vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Count the occurrences of vowels using LINQ
            int count = lowerCaseText.Count(c => vowels.Contains(c));

            return count;
        }
    }
}
