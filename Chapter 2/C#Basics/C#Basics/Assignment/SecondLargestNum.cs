namespace C_Basics.Assignment
{
    internal class SecondLargestNum
    {
        public static void GetSecondLargest() {
            int[] arr = { 10, 25, 3, 56, 41 };

            int first = arr[0];
            int second = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                int n = arr[i];

                if (n > first)
                {
                    second = first;
                    first = n;
                }
                else if (n > second && n != first)
                {
                    second = n;
                }
            }

            Console.WriteLine("Second Largest: " + second);
        }



        public static void GetSecondLargestFromUser()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            int first = arr[0];
            int second = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }

            Console.WriteLine("Second Largest: " + second);
        }
    }






}
