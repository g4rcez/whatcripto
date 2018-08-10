using System;
using System.Collections.Generic;
using System.Linq;
using Whatcripto.utils;

namespace Whatcripto.ciphers {
    public class CesarCipher : CipherDetect {
        public CesarCipher () { }
        public string cleanText (string encripted) {
            List<string> bruteFroce = new List<string> ();
            for (int i = 0; i <= 26; i++) {
                string output = string.Empty;
                foreach (char @char in encripted) {
                    output += Strings.getCase (@char, 26 - i);
                }
                bruteFroce.Add (output);
            }
            return String.Join ("\t", bruteFroce);
        }

        public bool identify (string encripted) => false;

        public string name () => "Cesar Cipher";
    }
}
