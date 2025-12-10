namespace Chapter3_4
{
    internal class CollectionGeneric
    {
        public static void DemoList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);
            numbers.Add(7);
            numbers.Remove(2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Insert(3, 24);

            numbers.RemoveAt(2);


            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }

        //Stack is LIFO data structure
        public static void DemoStack()
        {
            //Stack<string> stack = new Stack<string>();
            //stack.Push("First");
            //stack.Push("Second");
            //stack.Push("Third");
            //// print elements of the stack 
            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            Stack<string> colors = new Stack<string>();
            // adds "Red" and "Blue" to the stack
            colors.Push("Red");
            colors.Push("Blue");
            // removes element from the top of the colors stack 
            var removedElement = colors.Pop(); // "Blue" is removed
            Console.WriteLine("Removed Element: " + removedElement);
            // prints "Blue"
        }

        //Queue is FIFO data structure
        public  static void DemoQueue()
        {
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("First");
            //queue.Enqueue("Second");
            //queue.Enqueue("Third");

            //// print elements of the queue 
            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            Queue<string> colors = new Queue<string>();

            // adds "Red" and "Blue" to the queue
            colors.Enqueue("Red");
            colors.Enqueue("Blue");

            // removes element from the beginning of the colors queue 
            var removedElement = colors.Dequeue(); // "Red" is removed

            Console.WriteLine("Removed Element: " + removedElement);

            // prints "Red"

        }

        //sortedList is a collection of key/value pairs that are sorted by the keys and are accessible by key and by index.
        public static void DemoSortedList()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            // Adding key-value pairs to the SortedList
            sortedList.Add(3, "Three");
            sortedList.Add(1, "One");
            sortedList.Add(2, "two two");
            sortedList.Add(2, "Two");
            // Iterating through the SortedList
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            // Accessing a value by its key
            string value = sortedList[2];
            Console.WriteLine($"Value for key 2: {value}");

        }

        }
}
