using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Whatcripto.ciphers {
    public class BaconianCipher : CipherDetect {

        private Dictionary<string, string> Dictionary = new Dictionary<string, string>();

        public BaconianCipher() {
            Dictionary.Add("AAAAA", "A");
            Dictionary.Add("AAAAB", "B");
            Dictionary.Add("AAABA", "C");
            Dictionary.Add("AAABB", "D");
            Dictionary.Add("AABAA", "E");
            Dictionary.Add("AABAB", "F");
            Dictionary.Add("AABBA", "G");
            Dictionary.Add("AABBB", "H");
            Dictionary.Add("ABAAA", "I");
            Dictionary.Add("ABAAB", "J");
            Dictionary.Add("ABABA", "K");
            Dictionary.Add("ABABB", "L");
            Dictionary.Add("ABBAA", "M");
            Dictionary.Add("ABBAB", "N");
            Dictionary.Add("ABBBA", "O");
            Dictionary.Add("ABBBB", "P");
            Dictionary.Add("BAAAA", "Q");
            Dictionary.Add("BAAAB", "R");
            Dictionary.Add("BAABA", "S");
            Dictionary.Add("BAABB", "T");
            Dictionary.Add("BABAA", "U");
            Dictionary.Add("BABAB", "V");
            Dictionary.Add("BABBA", "W");
            Dictionary.Add("BABBB", "X");
            Dictionary.Add("BBAAA", "Y");
            Dictionary.Add("BBAAB", "Z");
        }

        public string cleanText(string encripted) {
            encripted = encripted.ToUpper();
            List<string> groups = (from Match m in Regex.Matches(encripted, @"[ABab]{5}")select m.Value).ToList();
            string decipher = string.Empty;
            foreach (string group in groups) {
                decipher += Dictionary[group];
            }
            return decipher;
        }

        public bool identify(string encripted) => Regex.Match(encripted, "^[AB ab]+$").Success;

        public string name() => "Baconian Cipher";
    }
}
