using System;
using Datastructure.Datastructure;
using Datastructure.SortedAlgorithms;
using Datastructure.SearchAlgorithms;
namespace Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 10, 3, 5, 1, 6 };
            int[] arr1 = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(1, 50);
            }
            DisplayArray(arr);
            HeapSort.Sort(arr);
            DisplayArray(arr);

            DisplayArray(arr1);
            HeapSort.Sort(arr1);
            DisplayArray(arr1);
        }
        public static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }

}
