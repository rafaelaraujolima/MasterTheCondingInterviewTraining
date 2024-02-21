using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class ReverseString2
    {
        public static string ReverseTheString(string str) 
        {
            if (str != null)
            {
                char[] stringArray = str.ToCharArray();
                Array.Reverse(stringArray);

                string reversedStr = new string(stringArray);
                return reversedStr;
            }
            return null;
        }
    }
}
