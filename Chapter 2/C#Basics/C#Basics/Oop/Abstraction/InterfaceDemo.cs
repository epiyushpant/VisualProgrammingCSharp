

namespace C_Basics.Oop.Abstraction
{

    interface IPolygon
    {
        // method without body
        void calculateArea(int l, int b);

    }

    class Rectangle : IPolygon
    {

        // implementation of methods inside interface
        public void calculateArea(int l, int b)
        {

            int area = l * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }

    public class InterfaceDemo
    {
        public static void RunDemo()
        {
            Rectangle r1 = new Rectangle();
            r1.calculateArea(100, 200);
        }
    }
}
