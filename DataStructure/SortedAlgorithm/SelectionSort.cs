using System;
namespace DatastructureAndAlogDatastructurerithms.SortedAlgorithms
{
    public static class SelectionSort
    {
        private static void Swap(ref int x , ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Sort(int[] arr)
        {
            for (int i = 0;  i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ( arr[j] < arr[min])
                        min = j;
                }
                if (min != i)
                {
                    Swap(ref arr[i] ,ref  arr[min]); 
                }
            }
        }
    }
}
