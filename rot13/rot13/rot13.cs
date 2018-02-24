using System;

namespace rot13
{
    public class Rot13
    {
        public string Rot13_helper(string input)
        {
            string ans = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 'a' && input[i] <= 'm') || (input[i] >= 'A' && input[i] <= 'M'))
                    ans += Convert.ToChar(input[i] + 13);
                else if ((input[i] >= 'n' && input[i] <= 'z') || (input[i] >= 'N' && input[i] <= 'Z'))
                    ans += Convert.ToChar(input[i] - 13);
                else
                    ans += input[i];
            }
            return ans;
        }
    }
}
