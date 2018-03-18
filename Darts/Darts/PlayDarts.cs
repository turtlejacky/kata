using System;

namespace Darts
{
    public class PlayDarts
    {
        public string GetScore(double x, double y)
        {
            var distance = GetDistance( x, y );
            var slope = Math.Abs(GetSlope(x, y));
            var area = GetArea(x, y);// 1,2,3,4

            var score = 0;
            if ( area == 1 ){
                if (slope < 0.1584)
                    score = 6;
                else if (slope < 0.5095)
                    score = 13;
                else if (slope < 1)
                    score = 4;
                else if (slope < 1.963)
                    score = 18;
                else if (slope < 6.314)
                    score = 1;
                else
                    score = 20;
                
            } else if ( area == 2 ) {
                if (slope < 0.1584)
                    score = 11;
                else if (slope < 0.5095)
                    score = 14;
                else if (slope < 1)
                    score = 9;
                else if (slope < 1.963)
                    score = 12;
                else if (slope < 6.314)
                    score = 5;
                else
                    score = 20;
                
            } else if ( area == 3 ) {
                if (slope < 0.1584)
                    score = 11;
                else if (slope < 0.5095)
                    score = 8;
                else if (slope < 1)
                    score = 16;
                else if (slope < 1.963)
                    score = 7;
                else if (slope < 6.314)
                    score = 19;
                else
                    score = 3;
            } else if ( area == 4 ) {
                if (slope < 0.1584)
                    score = 6;
                else if (slope < 0.5095)
                    score = 10;
                else if (slope < 1)
                    score = 15;
                else if (slope < 1.963)
                    score = 2;
                else if (slope < 6.314)
                    score = 17;
                else
                    score = 3;
            }





            if (distance < 6.35)
                return "DB";
            else if (distance < 15.9)
                return "SB";
            else if (distance < 99)
                return score.ToString();
            else if (distance < 107)
                return "T"+score;
            else if (distance < 162)
                return score.ToString();
            else if (distance < 170)
                return "D" + score;
            else
                return "X";
        }

        public double GetDistance( double x, double y ){
            return Math.Sqrt(x * x + y * y);
        }

        public double GetSlope( double x, double y ) {
            return y / x;
        }
        public int GetArea( double x, double y ) {
            if (x > 0)
            {
                if (y > 0)
                    return 1;
                else
                    return 4;
            }
            else
            {
                if (y > 0)
                    return 2;
                else
                    return 3;
            }
        }
    }
}
