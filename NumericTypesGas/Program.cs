using System;

namespace NumericTypesGas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many miles have you driven: ");
            int milesDriven = int.Parse(Console.ReadLine());
            Console.Write("How many gallons of gas did you use: ");
            int gallonsGasUsed = int.Parse(Console.ReadLine());
            double mpg = (double)milesDriven / (double)gallonsGasUsed;
            Console.Write("Your miles per gallon are: " + Math.Round(mpg, 2));
            Console.ReadLine();
        }
    }
}
