namespace C_Basics.Class.MultipleInheritance
{
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("Class A: Show()");
        }
    }

    class B : A
    {
        public override void Show()
        {
            Console.WriteLine("Class B: Show()");
        }
    }

    class C : A
    {
        public override void Show()
        {
            Console.WriteLine("Class C: Show()");
        }
    }

    // ❌ Attempting multiple inheritance
    //class D : B, C   // ❌ Error here
    //{
    //}

    // Explanation: 
    //A class inherits from two classes that both inherit from the same base class, creating multiple paths to the same ancestor.
    //This causes ambiguity about which version of a method or property should be used.
    // To resolve the diamond problem, we can use interfaces
}

