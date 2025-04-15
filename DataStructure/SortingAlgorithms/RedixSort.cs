using System;
using System.Linq;

namespace DataStructure.SortingAlgorithms
{
    public static class RedixSort
    {
        private static void CountSortPos(int[] arr, int pos)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / pos) % 10;
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / pos) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        public static void Sort(int[] arr)
        {
            int maxElement = arr.Max();
            for (int pos = 1; maxElement / pos > 0; pos *= 10)
            {
                CountSortPos(arr, pos);
            }
        }
    }
}
