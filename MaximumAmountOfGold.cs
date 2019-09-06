using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumAmountOfGold
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLiseInput = Console.ReadLine().Split();
            int capacity = Int32.Parse(firstLiseInput[0]);
            int numberOfIngots = Int32.Parse(firstLiseInput[1]);

            string[] ingotInput = Console.ReadLine().Split();

            int[] ingots = new int[numberOfIngots];

            for(int i = 0; i < numberOfIngots; i++)
            {
                ingots[i] = Int32.Parse(ingotInput[i]);
            }

            int[,] dynamicArray = new int[numberOfIngots + 1, capacity + 1];

            for (int i = 1; i <= numberOfIngots; i++)
            {
                for (int k = 1; k <= capacity; k++)
                {
                    int cont = ingots[i - 1];
                    if (k - cont >= 0)
                        dynamicArray[i, k] = Math.Max(dynamicArray[i - 1, k], dynamicArray[i - 1, k - cont] + cont);
                    else
                        dynamicArray[i, k] = dynamicArray[i - 1, k];
                }
            }

            Console.WriteLine(dynamicArray[numberOfIngots, capacity]);
            Console.Read();
        }
    }
}
