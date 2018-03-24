using System;
using System.Collections.Generic;

namespace Darts
{
    public class PlayDarts
    {
        public string GetScore(double x, double y)
        {
            var distance = GetDistance( x, y );
            var slope = Math.Abs(GetSlope(x, y));
            var area = GetArea(x, y);// 1,2,3,4

            var radians = Math.Atan(Math.Abs(GetSlope(x, y)));
            var angle = radians * (180 / Math.PI);

            Dictionary<int, int> scoreOfArea1 = new Dictionary<int, int>()  // tan score
            {
                {9 , 6}, { 27, 13 }, { 45, 4 }, { 63, 18 },{ 81, 1 },{ 90 , 20 }
            }; 
            Dictionary<int, int> scoreOfArea2 = new Dictionary<int, int>()  // tan score
            {
                {9 , 11}, { 27, 14 }, { 45, 9 }, { 63, 12 },{ 81, 5 },{ 90 , 20 }
            }; 
            Dictionary<int, int> scoreOfArea3 = new Dictionary<int, int>()  // tan score
            {
                {9 ,11}, { 27, 8 }, { 45, 16 }, { 63, 7 },{ 81, 19 },{ 90 , 3 }
            }; 
            Dictionary<int, int> scoreOfArea4 = new Dictionary<int, int>()  // tan score
            {
                {9 , 6}, { 27, 10 }, { 45, 15 }, { 63, 2 },{ 81, 17 },{ 90 , 3 }
            };


            Dictionary<int, Dictionary<int, int>> scoreOfAll = new Dictionary<int, Dictionary<int, int>>()
            { { 1, scoreOfArea1 } , { 2, scoreOfArea2 },  { 3, scoreOfArea3 }, { 4, scoreOfArea4 }};

            var score = 0;
            if ( angle < 9)
                score = scoreOfAll[area][9];
            else if (angle < 27)
                score = scoreOfAll[area][27];
            else if (angle < 45)
                score = scoreOfAll[area][45];
            else if (angle < 63)
                score = scoreOfAll[area][63];
            else if (angle < 81)
                score = scoreOfAll[area][81];
            else
                score = scoreOfAll[area][90];


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
                return y > 0 ? 1 : 4;
            else
                return y > 0 ? 2 : 3;
        }
    }
}
