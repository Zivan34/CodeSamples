using System;
using System.Collections.Generic;
using System.Linq;

namespace Greedy2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            List<Int64> items = new List<Int64>();
            foreach (string s in tokens)
            {
                items.Add(Int64.Parse(s));
            }
            Console.WriteLine(getMaxPairwiseProductFast(items));
            Console.ReadLine();
        }

        static Int64 getMaxPairwiseProductFast(List<Int64> numbers)
        {
            Int64 maxIndex1 = -1;
            Int64 maxIndex2 = -1;
            if (numbers.Count == 2)
            {
                maxIndex1 = numbers[0];
                maxIndex2 = numbers[1];
            }
            else
            {
                foreach (Int64 i in numbers)
                {
                    if (i >= maxIndex1)
                    {
                        maxIndex2 = maxIndex1;
                        maxIndex1 = i;
                    }
                    else if (i>= maxIndex2)
                    {
                        maxIndex2 = i;
                    }
                }
            }
            return maxIndex1 * maxIndex2;
        }
    }
}
