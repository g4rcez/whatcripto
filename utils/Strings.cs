using System;

namespace Whatcripto.utils {
    public abstract class Strings {
        public static char getCase (char @char, int key) {
            if (!char.IsLetter (@char)) {
                return @char;
            }
            char code = char.IsUpper (@char) ? 'A' : 'a';
            return Convert.ToChar ((((@char + key) - code) % 26) + code);
        }
    }
}
