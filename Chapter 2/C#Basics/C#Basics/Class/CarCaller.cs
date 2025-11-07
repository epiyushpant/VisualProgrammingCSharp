using C_Basics.Class.PartialClass;

namespace C_Basics.Class
{
    internal class CarCaller
    {
        public static void GetCar()
        {
            Car car1 = new Car("Red", "Toyota", 2020);
            Car car2 = new Car("Blue", "Honda", 2018);

            // Using the objects
            car1.DisplayInfo(); // Output: Color: Red, Model: Toyota, Year: 2020
            car2.DisplayInfo(); // Output: Color: Blue, Model: Honda, Year: 2018

            // Accessing and modifying properties
            car1.Color = "Black";
            car1.DisplayInfo();


            //// Remove references
            //car1 = null;
            ////car2 = null;


            //GC.Collect();      // Force garbage collection (not recommended in real apps)
            //GC.WaitForPendingFinalizers();

        }
    }
}
