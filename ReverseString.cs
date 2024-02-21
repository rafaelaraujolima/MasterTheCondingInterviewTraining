using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterTheCodingInterviewTraining
{
    internal static class ReverseString
    {
        public static string ReverseTheString(string str)
        {
            
            if (str != null)
            {
                string reverseString = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverseString += str[i];
                }
                return reverseString;
            }
            return null;
        }
    }
}
