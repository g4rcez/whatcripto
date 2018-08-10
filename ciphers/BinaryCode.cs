using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Whatcripto.ciphers {
    public class BinaryCode : CipherDetect {
        public string cleanText(string encripted) {
            List<Byte> byteList = new List<Byte>();
            for (int i = 0; i < encripted.Length; i += 8) {
                byteList.Add(Convert.ToByte(encripted.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        public bool identify(string encripted) => Regex.Match(encripted, "^[01]+$").Success;

        public string name() => "Binary";
    }
}
