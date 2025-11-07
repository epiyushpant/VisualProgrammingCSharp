namespace C_Basics.Class
{
    public class ShapeCaller
    {
        public static void GetShape()
        {
            //calling using method overrriding 

            Shape rect = new Rectangle(10, 5);
            Shape circle = new Circle(7);
            Shape triangle = new Triangle(10, 8);
            Shape square = new Square(6);

            Console.WriteLine("Area of Rectangle: " + rect.Area());
            Console.WriteLine("Area of Circle: " + circle.Area());
            Console.WriteLine("Area of Triangle: " + triangle.Area());
            Console.WriteLine("Area of Square: " + square.Area());
        }

        public static void GetShapeOverloading()
        {
            //calling using method overloading 

            Shapes shapes = new Shapes();

            Console.WriteLine("Area of Rectangle: " + shapes.Area(10, 5));
            Console.WriteLine("Area of Circle: " + shapes.Area(7.0));
            Console.WriteLine("Area of Triangle: " + shapes.Area(10, 8, true));
            Console.WriteLine("Area of Square: " + shapes.Area(6));
        }
    }
}
