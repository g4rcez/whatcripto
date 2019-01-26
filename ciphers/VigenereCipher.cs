using System;
using System.Text;
using whatcripto.utils;

namespace whatcripto.ciphers
{
    public class VigenereCipher : CipherDetect
    {

        private string key;

        public VigenereCipher(string key)
        {
            this.key = key;
        }

        public string cleanText(string encripted)
        {
            StringBuilder output = new StringBuilder();
            int nonCount = 0;
            for (int i = 0; i < encripted.Length; ++i)
            {
                if (char.IsLetter(encripted[i]))
                {
                    bool isUpper = char.IsUpper(encripted[i]);
                    char offset = Strings.charOffset(encripted[i]);
                    int keyIndex = (i - nonCount) % key.Length;
                    int index = -1 * ((isUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset) + encripted[i];
                    output.Append(Convert.ToChar(mod(index - offset) + offset));
                }
                else
                {
                    output.Append(encripted[i]);
                    nonCount++;
                }
            }
            return output.ToString();
        }

        private int mod(int a) => (a % 26 + 26) % 26;

        public bool identify(string encripted) => this.key.Length > 0;

        public string name() => "Vigenere Cipher";
    }
}
