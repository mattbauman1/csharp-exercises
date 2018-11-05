using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The area of the rectangle is: " + findArea());
            Console.ReadLine();
        }

        static double findArea()
        {
            int radius = -1;
            while (radius < 0)
            {
                Console.Write("Enter a radius (must be positive number): ");
                radius = int.Parse(Console.ReadLine());
            }
            double area = (double)radius * (double)radius * Math.PI;
            return area;
        }
    }
}
