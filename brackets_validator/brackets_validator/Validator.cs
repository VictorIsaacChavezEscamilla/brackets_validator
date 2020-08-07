using System.Collections.Generic;
using System.Linq;

namespace brackets_validator
{
    public class Validator
    {
        private readonly Dictionary<char, char> BracketsDictionary = new Dictionary<char, char>
        {
            { '{','}' },
            { '(',')' },
            { '[',']' },
        };

        public bool IsBalanceBrackets(string strValue)
        {
            var bracketStack = new Stack<char>();

            foreach (char c in strValue)
            {
                if (BracketsDictionary.ContainsKey(c))
                {
                    bracketStack.Push(c);
                    continue;
                }

                bracketStack.TryPop(out char top);

                if (!IsCloseBracket(top, c))
                    return false;
            }

            return !bracketStack.Any();
        }

        private bool IsCloseBracket(char open, char close)
        {
            BracketsDictionary.TryGetValue(open, out char correspondingClosure);
            return correspondingClosure == close;
        }
    }
}
