namespace C_Basics.Class
{
    public class Car
    {
        // Fields
        private string _color;
        private string _model;
        private int _year;

        // Property for Color
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        // Property for Model, short hand way 
        public string Model { get; set; }


        // Property for Year , conditions in prop 
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 1886) // The first car was invented in 1886
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentException("Year must be greater than 1886");
                }
            }
        }

        // Constructor
        public Car(string color, string model, int year)
        {
            Color = color;
            Model = model;
            Year = year;
        }

        // Destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }


        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Color: {Color}, Model: {Model}, Year: {Year}");
        }
    }
}
