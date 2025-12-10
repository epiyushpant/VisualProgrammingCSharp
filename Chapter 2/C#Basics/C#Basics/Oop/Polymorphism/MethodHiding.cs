namespace C_Basics.Oop.Polymorphism
{
    public class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent Class Show Method");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method");
        }
    }
    public class Child : Parent
    {
        //Method Overriding
        public override void Show()
        {
            Console.WriteLine("Child Class Show Method");
        }
        //Method Hiding/Shadowing
        public new void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
    }

    public class MethodHiding
    {
        public static void GetMethodHidingDemo()
        {
            Parent parent = new Parent();
            Child child = new Child();
            Parent parentRefChild = new Child();

            // Calling methods on Parent class object
            parent.Show();    // Outputs: Parent Class Show Method
            parent.Display(); // Outputs: Parent Class Display Method

            // Calling methods on Child class object
            child.Show();    // Outputs: Child Class Show Method
            child.Display(); // Outputs: Child Class Display Method

            // Calling methods on Parent reference pointing to Child object
            parentRefChild.Show();    // Outputs: Child Class Show Method (Overridden method)
            parentRefChild.Display(); // Outputs: Parent Class Display Method (Hidden method)


            //Method Hiding vs Method Overriding:

            //With method overriding, you can re-implement only virtual methods. On the other hand, with Method Hiding, you can re-implement any methods.

            // In method overriding, the derived class provides a new implementation for a method defined in the base class using the 'override' keyword.
            // In method hiding, the derived class defines a new method with the same name as a method in the base class using the 'new' keyword.

            // When a base class reference points to a derived class object:
            // For overridden methods, the derived class's implementation is called (dynamic binding).
            // For hidden methods, the base class's implementation is called (static binding).

            /*
             Note : parent class reference variable even if created by using the child class instance, 
            cannot access any members which are purely defined inside the child class but can call
            the overriding methods of the child class because overridden members are not considered
            as pure child class members, but the members which are re-implemented inside the child 
            class by using the approach of hiding are considered as pure child class members and
            cannot be accessed by Parent reference variable

            */

}
}
}

