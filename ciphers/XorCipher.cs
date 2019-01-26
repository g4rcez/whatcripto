using System.Collections.Generic;
using System;
using System.Text;
namespace whatcripto.ciphers
{
    public class XorCipher : CipherDetect
    {
        private string key;

        public XorCipher(string key)
        {
            this.key = key.Trim();
        }

        public string cleanText(string input)
        {
            return XOR(input);
        }

        private string XOR(string text)
        {
            var result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int charValue = Convert.ToInt32(text[i]); //get the ASCII value of the character
                result.Append(char.ConvertFromUtf32(charValue ^= key[i % key.Length]));
            }
            return result.ToString();
        }

        public bool identify(string encripted)
        {
            return true;
        }

        public string name()
        {
            return "XOR Cipher";
        }
    }
}