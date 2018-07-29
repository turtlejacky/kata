namespace getMiddleChar
{
    public static class MiddleCharacter
    {
        public static string GetMiddleCharacter(this string s)
        {
            if (s.Length < 3)
            {
                return s;
            }
            return LengthIsOdd(s) ? OneMiddleWord(s) : TwoMiddleWords(s);
        }

        private static bool LengthIsOdd(string s)
        {
            return s.Length % 2 == 1;
        }

        private static string OneMiddleWord(string s)
        {
            return s.Substring(s.Length / 2, 1);
        }

        private static string TwoMiddleWords(string s)
        {
            return s.Substring(s.Length / 2 - 1, 2);
        }
    }
}