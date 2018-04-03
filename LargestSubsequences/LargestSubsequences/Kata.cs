using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
 
namespace LargestSubsequences
{
    public class Kata
    {
        public static int LargestSum(int[] arr)
        {
            int sumMax = 0;
            int[] dynamicArr= new int[arr.Length+1];
            dynamicArr[0] = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                dynamicArr[i + 1] = Math.Max(dynamicArr[i] + arr[i], 0 );
                sumMax = Math.Max(dynamicArr[i + 1], sumMax);
            }
            return sumMax;
        }


     
    }
}
