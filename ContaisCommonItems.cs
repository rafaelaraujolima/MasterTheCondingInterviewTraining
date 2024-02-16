using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class ContaisCommonItems
    {
        public static bool HasCommonItems(Object[] arr1, Object[] arr2)
        {
            if (arr1.Length > 0 && arr2.Length > 0)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i].Equals(arr2[j]))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }   
    }
}
