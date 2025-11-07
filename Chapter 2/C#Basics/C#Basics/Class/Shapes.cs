namespace C_Basics.Class
{
    class Shapes
    {
        //Area of rectangle 
        public double Area(double length, double breadth)
        {
            return length * breadth;
        }

        // Area of Circle
        public double Area(double radius)
        {
            return 3.14159 * radius * radius;
        }

        // Area of Triangle
        public double Area(double baseLength, double height, bool isTriangle)
        {
            return 0.5 * baseLength * height;
        }

        // Area of Square
        public double Area(int side)
        {
            return side * side;
        }
    }

}
