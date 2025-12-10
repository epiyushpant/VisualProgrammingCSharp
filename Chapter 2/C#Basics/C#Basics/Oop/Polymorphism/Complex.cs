namespace C_Basics.Oop.Polymorphism
{
    public class Complex
    {
        public int Real, Imag;

        public Complex(int r = 0, int i = 0)
        {
            Real = r;
            Imag = i;
        }

        // Overload + operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }

        // Overload - operator
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }

        // Overload == operator
        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.Real == c2.Real && c1.Imag == c2.Imag);
        }

        // Overload != operator
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        // Must override Equals and GetHashCode when overloading == and !=
        //public override bool Equals(object obj)
        //{
        //    Complex c = (Complex)obj;
        //    return this == c;
        //}

        //public override int GetHashCode()
        //{
        //    return (Real, Imag).GetHashCode();
        //}

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imag}i");
        }
    }
}
