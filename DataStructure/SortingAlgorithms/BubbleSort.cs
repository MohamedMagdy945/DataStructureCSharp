using System;
namespace Datastructure.SortedAlgorithms
{
    public static class BubbleSort
    {
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length  - 1 ; j++)  // optimization : arr.Length - i - 1
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }

    }
}
