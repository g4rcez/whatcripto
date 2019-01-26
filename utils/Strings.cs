using System;
using System.Collections.Generic;

namespace whatcripto.utils
{
    public abstract class Strings
    {
        public static char getCase(char @char, int key)
        {
            if (!char.IsLetter(@char))
            {
                return @char;
            }
            char code = charOffset(@char);
            return Convert.ToChar((((@char + key) - code) % 26) + code);
        }

        public static char charOffset(char @char)
        {
            return char.IsUpper(@char) ? 'A' : 'a';
        }

        public static bool plusThen4(string @string)
        {
            List<char> list = new List<char>();
            foreach (char @char in @string)
            {
                if (!list.Contains(@char))
                {
                    list.Add(@char);
                }
                if (list.Count > 4)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
