using System;
using System.Collections.Generic;

namespace PlayTwoString
{
    public class CombineHelper {

        public string WorkOnStrings(string a, string b) 
        {
            int[] NumsOfStringA = new int[26];
            int[] NumsOfStringB = new int[26];
            foreach( char ch in a ) { // 字串.ToLower();字串.ToUpper();
                NumsOfStringA[Char.ToLower(ch) - 'a']++ ;
            }
            foreach( char ch in b ) {
                NumsOfStringB[Char.ToLower(ch) - 'a']++;
            }


            return ChangeString( NumsOfStringB, a )+ ChangeString(NumsOfStringA, b);
        }


        public string ChangeString( int[] NumOfAnother, String now ){
            string ans = "";
            foreach (char ch in now)
            {
                if ((NumOfAnother[Char.ToLower(ch) - 'a']) % 2 == 0)
                    ans += ch;
                else
                    ans += UpperToLower_Or_LowerToUpper(ch);

            }
            return ans;
        }
         
        public char UpperToLower_Or_LowerToUpper( char ch ) {
            if ( ch >= 'A' && ch <= 'Z' )
                return Char.ToLower(ch);
            else
                return Char.ToUpper(ch);
        }
    }




}
