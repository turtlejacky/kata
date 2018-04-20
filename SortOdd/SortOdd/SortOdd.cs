using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortOdd
{
    public class Kata
    {
        public static int[] SortArray(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(x => x % 2 == 1).OrderBy(x=>x));
            return array.Select(x => x % 2 == 0 ? x : odds.Dequeue()).ToArray();
        }





    }
}
