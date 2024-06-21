namespace ztm_ds_algo_net._01_ds_arrays
{

    // Given 2 sorted integer arrays, return a sorted array containing all the items
    // [1,5,7] / [2,4,9,10] must return [1,2,4,5,7,9,10]
    public partial class Solution
    {
        public static void MergeSortedArrays()
        {
            Solution.WriteSeparator();           
            
            Console.WriteLine("02 - Merging Sorted Arrays [1, 5, 7], [2, 4, 9, 10]");

            foreach (var item in GetMergedArrays([1, 5, 7], [2, 4, 9, 10]))
                Console.Write($" {item} ");

            Solution.WriteSeparator();
        }
        private static int[] GetMergedArrays(int[] array1, int[] array2)
        {
            var myList = new List<int>(array1);
            myList.AddRange(array2);
            myList.Sort();
            return myList.ToArray();
        } 
    }
}
