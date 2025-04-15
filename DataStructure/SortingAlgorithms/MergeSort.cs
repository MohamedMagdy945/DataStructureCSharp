using System;
namespace Datastructure.SortingAlgorithms
{
    internal static  class MergeSort
    {
        public static int counter = 0;
        public static void Merge(int[] arr,int l, int middle, int r)
        {
            int k = 0;
            int[] arr2 = new int[r - l + 1];
            int i = l, j = middle + 1;
            while (i <= middle && j <= r)
            {
                if (arr[i] < arr[j])
                {
                    arr2[k++] = arr[i++];
                    counter++;
                }
                else { arr2[k++] = arr[j++]; counter++; }
            }
            while (i <= middle)
            {
                arr2[k++] = arr[i++];
                counter++;
            }

            while (j <= r) {
                arr2[k++] = arr[j++];
                counter++;
            }
            int count = 0;
            for (int z = l; z <= r; z++)
                arr[z] = arr2[count++];
        }
        public static void Sort(int[] arr , int l , int r)
        {
            if (l < r)
            {
                int middle = (l + r) / 2;
                Sort( arr,l, middle);
                Sort(arr, middle + 1, r);
                Merge(arr,l , middle, r);
            }
        }
       
    }
}
