using System;
namespace Datastructure.SearchAlgorithms
{
    // Array must be sorted
    internal static class BinarySearch
    {
        public static int Search(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (arr[middle] == key)
                    return middle + 1;
                else if (key > arr[middle])
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle - 1 ;
                }
            }
            return -1;
        }
        public static int RecursiveSearch(int[] arr, int key , int low , int high)
        {
            if (low > high) return -1;
            int middle = (low + high) / 2;
            if ((arr[middle] == key)) return middle ;
            if (key > arr[middle]) return RecursiveSearch(arr, key , middle + 1 , high);
            else return RecursiveSearch(arr , key , low , middle -1 );
        }

        public static int SearchinRotatedMatrix(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (arr[middle] == key)
                    return middle ;
                else if (arr[middle] >= arr[low])
                {
                    if ( key >= arr[low] && key <= arr[middle] )
                        high = middle - 1;
                    else
                    {
                        low = middle + 1;   
                    }
                        
                }
                else 
                {
                    if(key >= arr[middle] && key <= arr[high])
                        low = middle + 1;
                    else 
                        high = middle - 1;
                }
            }
            return -1;
        }
    }
}
