using System.Collections.Generic;

namespace PascalTriangle
{
    public class PascalTriangleHelper
    {
        public List<int> PascalsTriangle(int n)
        {
            var list = new List<int>();
            var count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        count = 1;
                    else
                        count = count * (i - j + 1) / j;
                    list.Add(count);
                }
            }
            return list;
        }
    }
}