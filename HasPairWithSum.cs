using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class HasPairWithSum
    {
        public static bool CheckIfHasPairWithSum(int[] arr, int sum)
        {
            //assuming it's ordered
            int low = 0;
            int hi = arr.Length - 1;

            while (low < hi)
            {
                if ((arr[low] + arr[hi]) == sum)
                    return true;
                else if ((arr[low] + arr[hi]) > sum)
                    hi--;
                else
                    low++;
            }
            
            return false;
        }
    }
}
