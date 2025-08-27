namespace C_Basics.Oop.Abstraction
{
    /* Abstrction : Hiding implementation detail of object and showing only essential features
     * of object   , 
     
      Focus on what an object does rather than how it does 
      implemnted using abstract class and interface 
      Helps in reducing complexity and increasing reusability 


     */ 


    abstract class Animal
    {
        public abstract void MakeSound(); // Abstract method (no implementation)

        public void Sleep()
        {
            Console.WriteLine("Sleeping..."); // Concrete method
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark! Bark!");
        }
    }

    class CallAbs
    {
        public static void CallAbstraction()
        {
            Animal myDog = new Dog();
            myDog.MakeSound(); // Output: Bark! Bark!
            myDog.Sleep();     // Output: Sleeping...  abishek
        }
    }

}
