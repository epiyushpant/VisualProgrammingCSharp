namespace C_Basics.Class.MultipleInheritance
{
    using System;

    interface IA
    {
        void Show();
    }

    interface IB : IA
    {
        new void Show();
    }

    interface IC : IA
    {
        new void Show();
    }

class D : IB, IC
{
    public void Show()
    {
        Console.WriteLine("Class D: Show()");
    }
}
}
