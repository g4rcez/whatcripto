using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using whatcripto.utils;

namespace whatcripto.ciphers {
    public class CesarCipher : CipherDetect {
        public CesarCipher() {}
        public string cleanText(string encripted) {
            List<string> bruteFroce = new List<string>();
            for (int i = 0; i <= 26; i++) {
                StringBuilder output = new StringBuilder();
                foreach (char @char in encripted) {
                    output.Append(Strings.getCase(@char, 26 - i));
                }
                bruteFroce.Add(output.ToString());
            }
            return String.Join("\t|=> ", bruteFroce);
        }

        public bool identify(string encripted) => Strings.plusThen4(encripted);

        public string name() => "Cesar Cipher";
    }
}
