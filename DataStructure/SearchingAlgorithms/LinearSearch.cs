using System;

namespace Datastructure.SearchAlgorithms
{
    internal class LinearSearch
    {
        public static int Search(int[] arr, int key)
        {
            int i = 0; 
            while(i < arr.Length)
            {
                if(arr[i++] == key)
                    return i - 1;
            }
            return -1;
        }
    }
}
