using System;

namespace Greedy1
{

    //The goal of this algorithm is to find the minimum number of coins needed to change 
    //the input value(an integer) into coins with denominations 1, 5, and 10.
    class Program
    {
        static void Main(string[] args)
        {
            int opCount = 0;
            int input = Int32.Parse(Console.ReadLine());

            while (input != 0)
            {
                if (input - 10 >= 0)
                {
                    input = input - 10;
                    opCount++;
                }
                else if(input - 5 >= 0)
                {
                    input = input - 5;
                    opCount++;
                }
                else
                {
                    input = input - 1;
                    opCount++;
                }
            }
            Console.WriteLine(opCount);
            Console.ReadKey();
        }
    }
}
