using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class MergeSortedArrays
    {
        public static int[] MergeTheArrays(int[] arr1, int[] arr2)
        {
            if (arr1 != null && arr2 != null)
            {
                int[] mergedArray = new int[arr1.Length + arr2.Length];

                int k = 0;

                int idxArr1 = 0;
                int idxArr2 = 0;

                while (idxArr1 < arr1.Length && idxArr2 < arr2.Length)
                {
                    if (arr1[idxArr1] <= arr2[idxArr2])
                    {
                        mergedArray[k++] = arr1[idxArr1++];
                    }
                    else
                    {
                        mergedArray[k++] = arr2[idxArr2++];
                    }
                }
                
                while (idxArr1 < arr1.Length)
                {
                    mergedArray[k++] = arr1[idxArr1++];
                }

                while (idxArr2 < arr2.Length)
                {
                    mergedArray[k++] = arr2[idxArr2++];
                }

                return mergedArray;
            }
            return [];
        }
    }
}



