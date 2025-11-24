//Program to convert fahrenheit to Celsius.
using System;
namespace FahrenheitToCelsius
{
     class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine()); ;
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            Console.ReadLine();
        }

        }
    }

