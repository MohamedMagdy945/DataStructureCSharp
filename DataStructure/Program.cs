using System;
using Datastructure.Datastructure;
using Datastructure.SortedAlgorithms;
using Datastructure.SearchAlgorithms;
using DataStructure.SortingAlgorithms;
namespace Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(1, 50);
            }
            
            DisplayArray(arr1);
            RedixSort.Sort(arr1);
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
