using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of long side: ");
            int longSide = int.Parse(Console.ReadLine());
            Console.Write("Length of short side: ");
            int shortSide = int.Parse(Console.ReadLine());
            int area = longSide * shortSide;
            Console.Write("The area of the rectangle is: " + area);
            Console.ReadLine();
        }
    }
}
