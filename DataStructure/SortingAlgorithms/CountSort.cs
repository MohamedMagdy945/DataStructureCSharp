
namespace DataStructure.SortingAlgorithms
{
    public static class CountSort
    {
        public static void Sort(int[] arr)
        {
            int maxValue = arr.Max();
            int[] count = new int[maxValue + 1];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)        
                count[arr[i]]++;
    
            for (int i = 1; i <= maxValue; i++)
                count[i] += count[i - 1];
            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }
         
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }
    }
}
