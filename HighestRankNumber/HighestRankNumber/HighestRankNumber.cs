using System.Linq;

namespace HighestRankNumber
{
    public class HighestRankNumber
    {
        public int HighestRank(int[] arr)
        {
            //before
            //var frequencyArr = arr.GroupBy(x => x).Select(x => new { Num = x.Key, Count = x.Count() });
            //return frequencyArr.OrderByDescending(x => x.Count).ThenByDescending(n => n.Num).First().Num;

            return arr.GroupBy(x => x).OrderBy(x => x.Count()).ThenBy(x => x.Key).Last().Key;
        }
    }
}