using System;
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

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    continue;
                for (var j = 0; j < array.Length; j++)
                {
                    if (array[j] % 2 == 0)
                        continue;
                    if (array[i] >= array[j]) continue;
                    var temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }

            return array;
        }
    }
}
