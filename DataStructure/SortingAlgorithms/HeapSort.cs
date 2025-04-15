using System;
namespace Datastructure.SortedAlgorithms
{
    public static class HeapSort
    {
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        private static void Heapify(int[] arr , int n , int index)
        {
;           if (index >= 0)
            {
                int max = index;
                int right = 2 * index + 2;
                int left = 2 * index + 1;
                if (index >= 0)
                {
                    if (left < n && arr[max] < arr[left])
                        max = left;
                    if (right < n && arr[max] < arr[right])
                        max = right;
                    if (max != index)
                    {
                        Swap(ref arr[max], ref arr[index]);
                        Heapify(arr, n, max);
                    }
                }
            }
        }
        public static void Sort(int[] arr)
        {

            int n = arr.Length;
            for (int i = n /2 -1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
            for (int i = n -1; i >= 0; i--)
            {
                Swap(ref arr[0], ref arr[i]);
                Heapify(arr, i, 0);
            }
        }
    }
}
