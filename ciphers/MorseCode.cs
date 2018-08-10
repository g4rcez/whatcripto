using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Whatcripto.ciphers {
    public class MorseCode : CipherDetect {
        private Dictionary<string, string> Dictionary = new Dictionary<string, string>();
        public MorseCode() {
            Dictionary.Add(".-", "A");
            Dictionary.Add("-...", "B");
            Dictionary.Add("-.-.", "C");
            Dictionary.Add("-..", "D");
            Dictionary.Add(".", "E");
            Dictionary.Add("..-.", "F");
            Dictionary.Add("--.", "G");
            Dictionary.Add("....", "H");
            Dictionary.Add("..", "I");
            Dictionary.Add(".---", "J");
            Dictionary.Add("-.-", "K");
            Dictionary.Add(".-..", "L");
            Dictionary.Add("--", "M");
            Dictionary.Add("-.", "N");
            Dictionary.Add("---", "O");
            Dictionary.Add(".--.", "P");
            Dictionary.Add("--.-", "Q");
            Dictionary.Add(".-.", "R");
            Dictionary.Add("...", "S");
            Dictionary.Add("-", "T");
            Dictionary.Add("..-", "U");
            Dictionary.Add("...-", "V");
            Dictionary.Add(".--", "W");
            Dictionary.Add("-..-", "X");
            Dictionary.Add("-.--", "Y");
            Dictionary.Add("--..", "Z");
            Dictionary.Add("/", " ");
            Dictionary.Add(".----", "1");
            Dictionary.Add("..---", "2");
            Dictionary.Add("...--", "3");
            Dictionary.Add("....-", "4");
            Dictionary.Add(".....", "5");
            Dictionary.Add("-....", "6");
            Dictionary.Add("--...", "7");
            Dictionary.Add("---..", "8");
            Dictionary.Add("----.", "9");
            Dictionary.Add("-----", "0");
            Dictionary.Add(".-.-.-", ".");
            Dictionary.Add("--..--", ",");
            Dictionary.Add("---...", ":");
            Dictionary.Add("..--..", "?");
            Dictionary.Add(".----.", "'");
            Dictionary.Add("-....-", "-");
            Dictionary.Add("-..-.", "/");
            Dictionary.Add(".--.-.", "@");
            Dictionary.Add("-...-", "=");
        }
        public string cleanText(string encripted) {
            string decode = string.Empty;
            foreach (string code in encripted.Split(" ")) {
                decode += Dictionary[code.Trim()];
            }
            return decode;
        }
        public string name() => "MorseCode";
        public bool identify(string encripted) {
            foreach (string code in encripted.Split(" ")) {
                try {
                    if (Dictionary.ContainsKey(code)) {
                        return true;
                    }
                } catch (System.Collections.Generic.KeyNotFoundException) {
                    return false;
                }
            }
            return false;
        }
    }
}
