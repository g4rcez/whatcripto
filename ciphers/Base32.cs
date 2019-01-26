using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace whatcripto.ciphers
{
    public class Base32 : CipherDetect
    {
        private static readonly char[] DIGITS;
        private static readonly int MASK;
        private static readonly int SHIFT;
        private static Dictionary<char, int> CHAR_MAP = new Dictionary<char, int>();
        private const string SEPARATOR = "-";

        static Base32()
        {
            DIGITS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".ToCharArray();
            MASK = DIGITS.Length - 1;
            SHIFT = numberOfTrailingZeros(DIGITS.Length);
            for (int i = 0; i < DIGITS.Length; i++) CHAR_MAP[DIGITS[i]] = i;
        }

        public string cleanText(string encripted)
        {
            var buffer = this.Decode(encripted);
            return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        }

        public bool identify(string encripted)
        {
            return Regex.Match(
                encripted
                .Replace("\n", ""),
                "^(?:[A-Z2-7]{8})*(?:[A-Z2-7]{2}={6}|[A-Z2-7]{4}={4}|[A-Z2-7]{5}={3}|[A-Z2-7]{7}=)?$")
                .Success;
        }

        public string name() => "Base32";

        private static int numberOfTrailingZeros(int i)
        {
            int y;
            if (i == 0) return 32;
            int n = 31;
            y = i << 16; if (y != 0) { n = n - 16; i = y; }
            y = i << 8; if (y != 0) { n = n - 8; i = y; }
            y = i << 4; if (y != 0) { n = n - 4; i = y; }
            y = i << 2; if (y != 0) { n = n - 2; i = y; }
            return n - (int)((uint)(i << 1) >> 31);
        }

        public byte[] Decode(string encoded)
        {
            encoded = encoded.Trim().Replace(SEPARATOR, "");
            encoded = Regex.Replace(encoded, "[=]*$", "");
            encoded = encoded.ToUpper();
            if (encoded.Length == 0)
            {
                return new byte[0];
            }
            int encodedLength = encoded.Length;
            int outLength = encodedLength * SHIFT / 8;
            byte[] result = new byte[outLength];
            int buffer = 0;
            int next = 0;
            int bitsLeft = 0;
            foreach (char c in encoded.ToCharArray())
            {
                if (!CHAR_MAP.ContainsKey(c))
                {
                    throw new Exception("Illegal character: " + c);
                }
                buffer <<= SHIFT;
                buffer |= CHAR_MAP[c] & MASK;
                bitsLeft += SHIFT;
                if (bitsLeft >= 8)
                {
                    result[next++] = (byte)(buffer >> (bitsLeft - 8));
                    bitsLeft -= 8;
                }
            }
            return result;
        }
    }
}