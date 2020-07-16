using System;
using System.Collections.Generic;

namespace NarcissisticNumbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Narcissistic Numbers
            // An n-digit number that is the sum of the n-th powers of its digits is
            // called an n-narcissistic. For n=3 there are only 4 numbers 
            // -{ 153 , 370 , 371 , 407 }- which are the sums of the cubes of their 
            // digits.
            // 153 = 1^3 + 5^3 + 3^3
            // 370 = 3^3 + 7^3 + 0^3
            // 371 = 3^3 + 7^3 + 1^3
            // 407 = 4^3 + 0^3 + 7^3

            PrintNarissistic(NarissisticOrder3());
        }
        private static void PrintNarissistic(List<List<int>> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Count; j++)
                {
                    Console.Write(list[i][j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        private static List<List<int>> NarissisticOrder3()
        {
            var results = new List<List<int>>();
            for (int x = 1; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        if (Equation3(x, y, z) == 0)
                            results.Add(MakeList3(x, y, z));
                    }
                }
            }
            return results;
        }
        private static List<int> MakeList3(int a, int b, int c)
        {
            //var nums = new List<int>() { a, b, c };
            var nums = new List<int>();
            nums.Add(a);
            nums.Add(b);
            nums.Add(c);

            return nums;
        }
        private static int Equation3(int x, int y, int z)
        {
            int first = x * x * x + y * y * y + z * z * z;
            int second = 100 * x + 10 * y + z;
            return first - second;
        }
    }
}
