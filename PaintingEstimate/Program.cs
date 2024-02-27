/*

	Logan Ercanbrack
	February 26, 2024
	SWDV-105

*/
using System;
using static System.Console;

namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
		{
			double length;
			double width;
			double height;

			WriteLine("Enter length of the room in feet:");
			length = double.Parse(ReadLine());
			WriteLine("Enter width of the room in feet:");
			width = double.Parse(ReadLine());
			WriteLine("Enter height of the room in feet:");
			height = double.Parse(ReadLine());

			double estimate = ComputeCost(length, width, height);

			WriteLine("Cost of job for {0} x {1} foot room is ${2:N0}", length, width, estimate);
		}


        private static double ComputeCost(double length, double width, double height)
        {
            const double PRICE = 16.2;

            double cost = ((length * height * 2) + (width * height * 2)) * PRICE;
            return cost;
        }
    }
}
