using System.Dynamic;
using System.Text;

namespace ztm_ds_algo_net._01_ds_arrays
{
    public static partial class Solution
    {
        public static string ReverseString(string str)
        {
            StringBuilder sb = new();
            foreach(char c in str.Reverse())
            {
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}

