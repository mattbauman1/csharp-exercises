using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numbers.AddRange(nums);
            Console.WriteLine(SumEvens(numbers));
            Console.ReadLine();
        }

        static int SumEvens(List<int> numbers)
        {
            int evenSum = 0;
            for(int i=0; i<numbers.Count; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    evenSum = evenSum + numbers[i];
                }
            }
            return evenSum;
        }
    }
}
