using System;
namespace Datastructure.SortedAlgorithms
{
    internal static class QuickSort
    {
        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static int Partition(int[] arr, int s , int e )
        {
            int pivot = arr[s] ;
            int l = s; 
            while ( e >= s )
            {
                while (s < arr.Length && arr[s] <= pivot  ) s++;
                while (arr[e] > pivot) e--;
                if (e > s)Swap(ref arr[s], ref arr[e]);
            }
            Swap(ref arr[e],ref  arr[l]);
            return e;
        }
        public static void Sort(int[] arr  , int s , int e)
        {
            if (s < e )
            {
                int pivot = Partition(arr, s, e);
                Sort(arr , s , pivot - 1 );
                Sort(arr, pivot + 1, e);
            }
        }
    }
}
