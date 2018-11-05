using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
        }
    }
}
