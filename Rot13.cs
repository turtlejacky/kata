using System;
using System.Collections.Generic;

namespace Rot13
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Rot13("This is my first ROT13 excercise!"));
        }

        public static string Rot13(string input)
        {
            string ans = "";
            for (int i = 0; i < input.Length; i++ ){
                if ((input[i] >= 'a' && input[i] <= 'm') || (input[i] >= 'A' && input[i] <= 'M'))
                    ans += Convert.ToChar(input[i] + 13);
                else if ( (input[i] >= 'n' && input[i] <= 'z') || (input[i] >= 'N' && input[i] <= 'Z') )
                    ans += Convert.ToChar(input[i] - 13);
                else 
                    ans += input[i];
            }
            return ans;
  }

    }


}