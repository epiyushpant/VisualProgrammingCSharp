using System;
     class Program
    {
        static void Main(string[] args)
        {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int n = arr.Length +1 ;
        int expectedsum = n * (n + 1) / 2;

        int actualsum = 0;
        foreach (int num in arr)
        {
            actualsum += actualsum;
        }
        int missingNumber = expectedsum - actualsum;

        Console.WriteLine("The missing number is :" + missingNumber);
    }
    }
