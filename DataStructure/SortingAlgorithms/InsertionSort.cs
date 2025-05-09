﻿using System;
namespace Datastructure.SortingAlgorithms
{
    internal static class InsertionSort 
    {
        public static void Sort(int[] arr)
        {
            for(int i = 1 ;  i < arr.Length ; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}
