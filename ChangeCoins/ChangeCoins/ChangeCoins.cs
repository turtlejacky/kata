using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCoins
{
    public class ChangeCoins
    {
        public static int CountCombinations(int money, int[] coins)
        {
            int[] dramaticArray = new int[money+1];
            dramaticArray[0] = 1;
            foreach (var coin in coins)
            {
                for (var j = coin; j <= money; j++)
                {
                    dramaticArray[j] = dramaticArray[j] + dramaticArray[j - coin];
                }
            }

            return dramaticArray[money];
        }
    }
}
