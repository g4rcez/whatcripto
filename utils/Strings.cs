using System;
namespace whatcripto.utils {
    public abstract class Strings {
        public static char getCase(char @char, int key) {
            if (!char.IsLetter(@char)) {
                return @char;
            }
            char code = charOffset(@char);
            return Convert.ToChar((((@char + key) - code) % 26) + code);
        }

        public static char charOffset(char @char) {
            return char.IsUpper(@char) ? 'A' : 'a';
        }
    }
}
