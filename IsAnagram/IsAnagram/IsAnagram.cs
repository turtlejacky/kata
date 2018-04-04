using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAnagram
{
    public class IsAnagramClass
    {
        public static bool IsAnagram(string test, string original)
        {
            var testArr = test.ToLower().ToCharArray().OrderBy(c => c);
            var orgArr = original.ToLower().ToCharArray().OrderBy(c => c);
            return testArr.SequenceEqual(orgArr);
        }

    }
}
