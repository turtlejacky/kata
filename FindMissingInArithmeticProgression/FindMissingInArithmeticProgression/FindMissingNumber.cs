using System.Collections.Generic;
using System.Linq;

namespace FindMissingInArithmeticProgression
{
    public class FindMissingNumber
    {
        public int FindMissing(List<int> list)
        {
            int gap = (list.Last() - list.First()) / list.Count;
            return list.Where((x, index) => x != list.First() + gap * index).First() - gap;
        }
    }
}
