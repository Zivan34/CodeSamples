using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3WayQuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            QuickSort(ref arr, 0, arrSize - 1);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void QuickSort(ref int[] input, int lowerBound, int higherBound)
        {
            int start = lowerBound - 1;
            int end = higherBound;
            int left = lowerBound - 1;
            int right = higherBound;
            int lowStart;

            if (higherBound <= lowerBound) return;
            int pivot = input[higherBound];
            while (true)
            {
                while (input[++start] < pivot) ;
                while (pivot < input[--end])
                {
                    if (end == lowerBound)
                    {
                        break;
                    }
                }

                if (start >= end)
                {
                    break;
                }

                Swap(ref input, start, end);

                if (input[start] == pivot)
                {
                    left = left + 1;
                    Swap(ref input, left, start);
                }

                if (pivot == input[end])
                {
                    right = right - 1;
                    Swap(ref input, end, right);
                }
            }

            Swap(ref input, start, higherBound); end = start - 1; start++;

            for (lowStart = lowerBound; lowStart < left; lowStart++, end--)
            {
                Swap(ref input, lowStart, end);
            }

            for (lowStart = higherBound - 1; lowStart > right; lowStart--, start++)
            {
                Swap(ref input, start, lowStart);
            }

            QuickSort(ref input, lowerBound, end);
            QuickSort(ref input, start, higherBound);
        }

        static void Swap(ref int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
