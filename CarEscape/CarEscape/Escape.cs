using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEscape
{
    public class Escape
    {
        public string[] escape(int[,] carpark)
        {
            var startPoint = FindTheStartRaw(carpark);
            List<string> ans = new List<string>();
            if (startPoint.Item1 == -1)
                return ans.ToArray();
            var raw = startPoint.Item1;
            var column = startPoint.Item2;
            while ( raw < carpark.GetLength(0) )
            {
                if (IsEndLevel(carpark, raw))
                {
                    MoveToExit(carpark, column, ans);
                    return ans.ToArray();
                }

                column = MoveToStair(carpark, raw, column, ans);
                raw += MoveDownStair(carpark, raw, column, ans);
            }
            
            return ans.ToArray();
        }

        private int MoveToStair(int[,] carpark, int raw, int column, List<string> ans)
        {
            var stairColumn = FindStair(carpark, raw);
            var step = Math.Abs(column - stairColumn);
            if (step != 0)
            {
                if (stairColumn > column)
                    ans.Add("R" + step);
                else
                    ans.Add("L" + step);
            }
            return stairColumn;
        }

        private int MoveDownStair(int[,] carpark, int raw, int column, List<string> ans)
        {
            var dowmStep = 1;
            while (raw + dowmStep < carpark.GetLength(0) &&
                   carpark[raw + dowmStep, column] == 1)
                dowmStep++;
            ans.Add("D" + dowmStep);
            return dowmStep;
        }

        private void MoveToExit(int[,] carpark, int column, List<string> ans)
        {
            var step = carpark.GetLength(1) - column - 1;
            if (step != 0)
                ans.Add("R" + step);
        }

        private bool IsEndLevel(int[,] carpark, int raw)
        {
            return raw == carpark.GetLength(0)-1;
        }

        public Tuple<int, int> FindTheStartRaw(int[,] carpark)
        {
            for (int i = 0; i < carpark.GetLength(0); i++ )
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 2)
                        return Tuple.Create(i,j);
                }
                

            }
            return Tuple.Create(-1, -1);
        }

        public int FindStair(int[,] carpark, int raw)
        {
            for (int j = 0; j < carpark.GetLength(1); j++)
            {
                if (carpark[raw, j] == 1)
                    return j;
            }
            return 0;
        }
    }
}
