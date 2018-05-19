using System.Linq;

namespace ReverseWord
{
    public class Reverse
    {
        public string ReverseSentence(string input)
        {
            var splitInput = input.Split(' ');
            return string.Join(" ", splitInput.Select(x => new string(x.Reverse().ToArray())));
        }
    }
}