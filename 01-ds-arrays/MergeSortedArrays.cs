namespace ztm_ds_algo_net._01_ds_arrays
{
    public partial class Solution
    {
        public static void MergeSortedArrays()
        {
            Solution.WriteSeparator();

            Console.WriteLine("Given the following arrays: [] / [1,2,3]");
            Console.WriteLine("02 - Merging Sorted Arrays When Array 1 is Empty");

            foreach (var item in GetMergedArrays([], [1, 2, 3]))
                Console.Write($" {item} ");

            Solution.WriteSeparator();
        }
        private static int[] GetMergedArrays(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
                return array2;
            if (array2.Length == 0)
                return array1;

            return [];
        } 
    }
}
