namespace C_Basics.Oop.Polymorphism
{
    public class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        //Overriding the virtual method in the derived class
        //public override void MakeSound()
        //{
        //    Console.WriteLine("Dog barks");
        //}
    }

    public class Cat : Animal
    {
        // Overriding the virtual method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    
    }
    
    public class MethodOverridingDemo
    {
        public static void GetOverriding() {

            Animal animal = new Animal();         
            Animal myDog = new Dog(); // Upcasting
            Animal myCat = new Cat(); // Upcasting

            animal.MakeSound(); // Outputs "Animal makes a sound"
            // Calling the overridden methods
            myDog.MakeSound(); // Outputs "Dog barks"
            myCat.MakeSound(); // Outputs "Cat meows"



            Dog dog = new Dog();
            dog.MakeSound();

            //BCRV - Base Class Reference Variable pointing to Derived Class Object will call the 
           // Derived Class overridden method.
        }
    }
}
