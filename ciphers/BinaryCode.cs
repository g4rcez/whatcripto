using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace whatcripto.ciphers
{
    public class BinaryCode : CipherDetect
    {
        public string cleanText(string encripted)
        {
            StringBuilder Binary = new StringBuilder();
            if (encripted.Contains(" "))
            {
                foreach (string group in encripted.Split(" "))
                {
                    if (group.Length != 8)
                    {
                        Binary.Append(group.PadLeft(8, '0'));
                    }
                    else
                    {
                        Binary.Append(group.PadLeft(8, '0'));
                    }
                }
            }
            else
            {
                Binary.Append(encripted);
            }
            string bytes = Binary.ToString();
            string @return = string.Empty;
            for (int i = 0; i < bytes.Length; i += 8)
            {
                Int32 integer = Convert.ToInt32(bytes.Substring(i, 8), 2);
                string hex = integer.ToString("X").PadLeft(4, '0');
                @return += Char.ConvertFromUtf32(int.Parse(hex, NumberStyles.HexNumber));
            }
            return @return;
        }

        public bool identify(string encripted) => Regex.Match(encripted, "^[0 1]+$").Success;

        public string name() => "Binary";
    }
}
