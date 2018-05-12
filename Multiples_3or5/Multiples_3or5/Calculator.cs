using System.Linq;

namespace Multiples__3or5
{
    public class Calculator
    {
        public int SumMultiples(int n)
        {
            return Enumerable.Range(0, n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}
