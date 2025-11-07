namespace C_Basics.Class
{
    // Base class
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public override double Area()
        {
            return Length * Breadth;
        }
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }

        public override double Area()
        {
            return 3.14159 * Radius * Radius;
        }
    }

    // Derived class: Triangle
    class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double b, double h)
        {
            BaseLength = b;
            Height = h;
        }

        public override double Area()
        {
            return 0.5 * BaseLength * Height;
        }
    }
    // Derived class: Square
    class Square : Shape
    {
        public double Side { get; set; }

        public Square(double s)
        {
            Side = s;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

}
