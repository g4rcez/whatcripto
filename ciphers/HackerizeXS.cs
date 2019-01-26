using System.Collections.Generic;
using System.Text;

namespace whatcripto.ciphers
{
    public class HackerizeXS : CipherDetect
    {
        Dictionary<char, string> Dictionary = new Dictionary<char, string>();

        public HackerizeXS()
        {
            Dictionary.Add('Λ', "a");
            Dictionary.Add('₪', "w");
            Dictionary.Add('¶', "q");
            Dictionary.Add('☰', "e");
            Dictionary.Add('┏', "r");
            Dictionary.Add('⊥', "t");
            Dictionary.Add('¥', "y");
            Dictionary.Add('ü', "u");
            Dictionary.Add('¡', "i");
            Dictionary.Add('☐', "o");
            Dictionary.Add('þ', "p");
            Dictionary.Add('§', "s");
            Dictionary.Add('Ð', "d");
            Dictionary.Add('∲', "f");
            Dictionary.Add('ç', "g");
            Dictionary.Add('ƴ', "v");
            Dictionary.Add('ß', "b");
            Dictionary.Add('∏', "n");
            Dictionary.Add('ღ', "m");
            Dictionary.Add('╫', "h");
            Dictionary.Add('¿', "j");
            Dictionary.Add('├', "k");
            Dictionary.Add('↑', "l");
            Dictionary.Add('ᶾ', "z");
            Dictionary.Add('✕', "x");
            Dictionary.Add('↻', "c");
            Dictionary.Add('▪', ".");
        }
        public string cleanText(string encripted)
        {
            StringBuilder decode = new StringBuilder();
            foreach (char @char in encripted)
            {
                try
                {
                    decode.Append(Dictionary[@char]);
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    decode.Append(@char);
                }
            }
            return decode.ToString();
        }
        public string name() => "HackerizeXS";
        public bool identify(string encripted)
        {
            foreach (char @char in encripted)
            {
                try
                {
                    if (Dictionary.ContainsKey(@char))
                    {
                        return true;
                    }
                }
                catch (System.Collections.Generic.KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;
        }
    }
}
