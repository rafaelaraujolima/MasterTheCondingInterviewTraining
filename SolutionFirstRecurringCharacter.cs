using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class SolutionFirstRecurringCharacter
    {
        public static int FirstRecurringCharacter(int[] arr)
        {
            HashSet<int> nums = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!nums.Add(arr[i]))
                    return arr[i];
            }

            return int.MinValue;
        }
    }
}
