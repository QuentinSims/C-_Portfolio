using System;

namespace AreaOfRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this program calculates the area of a rectangular room");
            Console.WriteLine("What is the length of the rectangular room in feet: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the width of the rectangular room in feet: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The length and width of the rectangular room is {length} and {width} respectively.");

            double roomInFeet = SquareFeet(length, width);
            Console.WriteLine($"The square feet of the rectangular room is {roomInFeet}.");

            decimal convertToMeters = ConversionFeetToMeters(roomInFeet);
            Console.WriteLine($"The meters squared of the rectangular room is {Math.Round(convertToMeters, 3)}.");

        }
        static double SquareFeet(double length, double width)
        {
            double squareFeet = length * width;
            return squareFeet;
        }

        static decimal ConversionFeetToMeters(double roomInFeet)
        {
            decimal feetToMeters = 0.09290304M;
            decimal conversion = Convert.ToDecimal(roomInFeet) * feetToMeters;
            return conversion;
        }

    }
}
