namespace C_Basics.Enums
{
    public class DemoEnum
    {
        public static  void GetEnumDemo()
        {
            // Declare a variable of type DayOfWeek
            DayOfWeek today = DayOfWeek.Sunday;

            // Display the value
            Console.WriteLine($"Today is: {today}");

            // Using enum in a switch statement
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Let's start the week with energy!");
                    break;
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                    Console.WriteLine("Midweek is here, keep going!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Almost the weekend!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Enjoy the weekend!");
                    break;
            }
        }


        public static  void FindDayFromDate()
        {
            Console.Write("Enter a date (yyyy-mm-dd): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime date))
            {
                DayOfWeek day = (DayOfWeek)date.DayOfWeek;
                Console.WriteLine($"That day is: {day}");
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }
        }


        public static void TrafficLightExampleWithoutEnum()
        {
            string light = "Red";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Light is: {light}");

                if (light == "Red")
                {
                    Console.WriteLine("Stop!");
                    light = "Green";
                }
                else if (light == "Green")
                {
                    Console.WriteLine("Go!");
                    light = "Yellow";
                }
                else if (light == "Yellow")
                {
                    Console.WriteLine("Slow down!");
                    light = "Red";
                }

                Console.WriteLine();
            }
        }

        public static void TrafficLightExampleWithEnum()
        {
            TrafficLight light = TrafficLight.Red;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Light is: {light}");

                switch (light)
                {
                    case TrafficLight.Red:
                        Console.WriteLine("Stop!");
                        light = TrafficLight.Green;
                        break;
                    case TrafficLight.Green:
                        Console.WriteLine("Go!");
                        light = TrafficLight.Yellow;
                        break;
                    case TrafficLight.Yellow:
                        Console.WriteLine("Slow down!");
                        light = TrafficLight.Red;
                        break;
                }

                Console.WriteLine();
            }
        }

    }
}
