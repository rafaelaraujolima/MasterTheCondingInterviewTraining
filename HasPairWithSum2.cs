using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class HasPairWithSum2
    {
        public static bool CheckIfHasPairWithSum(int[] arr, int sum)
        {
            //not assuming it's ordered
            HashSet<int> complements = new HashSet<int>();          

            for (int i = 0; i < arr.Length; i++)
            {
                if (complements.Contains(arr[i]))
                    return true;
                
                complements.Add(sum - arr[i]);
            }

            return false;
        }
    }
}
