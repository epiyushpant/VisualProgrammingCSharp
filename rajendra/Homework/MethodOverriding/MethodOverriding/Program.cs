using System;

namespace MethodOverriding
{
    class MyClass
    {
        public virtual void Area(int r)
        {
            float PI = 3.14f;
            float area = PI * r * r;
            Console.WriteLine($" Area of Circle: {area}");
        }

        public virtual void Area(int l, int b)
        {
            int area = l * b;
            Console.WriteLine($" Area of Rectangle: {area}");
        }

        public virtual void Area(double s)
        {
            double area = s * s;
            Console.WriteLine($" Area of Square: {area}");
        }

        public virtual void Area(double b, double h)
        {
            double area = 0.5 * b * h;
            Console.WriteLine($" Area of Triangle: {area}");
        }
    }

    class MyDerivedClass : MyClass
    {
        public override void Area(int r)
        {
            float PI = 3.14159f;
            float area = PI * r * r;
            Console.WriteLine($" Circle Area (more precise): {area}");
        }

        public override void Area(int l, int b)
        {
            int area = l * b;
            Console.WriteLine($"Rectangle Area (overridden): {area}");
        }

        public override void Area(double s)
        {
            double area = s * s;
            Console.WriteLine($"Square Area (overridden): {area}");
        }

        public override void Area(double b, double h)
        {
            double area = 0.5 * b * h;
            Console.WriteLine($"Triangle Area (overridden): {area}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass parent = new MyClass();
            MyDerivedClass child = new MyDerivedClass();

            Console.WriteLine("\nParent Class");
            parent.Area(10);
            parent.Area(20, 10);
            parent.Area(12.5);
            parent.Area(5.0, 8.0);

            Console.WriteLine("\nChild Class (Overridden Methods");
            child.Area(10);
            child.Area(20, 10);
            child.Area(12.5);
            child.Area(5.0, 8.0);
        }
    }
}
