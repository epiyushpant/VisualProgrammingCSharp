using System.Diagnostics;

namespace Chapter3_4
{
    internal class StringBuilder
    {
        public static void DemoStringBuilder()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello");
            sb.Append(" World");
            sb.AppendLine("!");
            sb.Replace("World", "C#");
            Console.WriteLine(sb.ToString());
        }

        public static void CompareStringVsStringBuilder()
        {
            int iterations = 50000;

            // ✅ Test string concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string s = "";
            for (int i = 0; i < iterations; i++)
            {
                s = s + i.ToString() + "hello";
            }
            sw1.Stop();
            Console.WriteLine("String concatenation time: " + sw1.ElapsedMilliseconds + " ms");

            // ✅ Test StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            System.Text.StringBuilder sb = new System.Text.StringBuilder(); // Use fully qualified name to avoid confusion with class name
            for (int i = 0; i < iterations; i++)
            {
                sb.Append(i.ToString()).Append("hello");
            }
            string result = sb.ToString();
            sw2.Stop();
            Console.WriteLine("StringBuilder time: " + sw2.ElapsedMilliseconds + " ms");
        }

        public static void DemoStringInterpolation()
        {
            string name = "Alice";
            int age = 30;
            string message = $"Name: {name}, Age: {age}";
            Console.WriteLine(message);
        }

        public static void StringManipulation()
        {
            string original = "  Hello, C# World!  ";
            string trimmed = original.Trim();
            string upper = trimmed.ToUpper();
            string replaced = upper.Replace("C#", "CSharp");
            Console.WriteLine(replaced);

        }

    }
}
