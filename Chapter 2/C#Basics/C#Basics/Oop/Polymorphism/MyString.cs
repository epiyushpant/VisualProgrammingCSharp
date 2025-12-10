namespace C_Basics.Oop.Polymorphism
{
    public class MyString
    {
        public string Value { get; private set; }

        public MyString(string value)
        {
            Value = value;
        }

        // Overloading the + operator
        public static MyString operator +(MyString s1, MyString s2)
        {
            return new MyString($"[{s1.Value}] + [{s2.Value}]");
        }

        public override string ToString()
        {
            return Value;
        }
    }  
 }
