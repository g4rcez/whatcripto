using System;
using System.Text;
using System.Text.RegularExpressions;

namespace whatcripto.ciphers
{
    public class Base64 : CipherDetect
    {
        public string cleanText(string encripted) => Encoding.UTF8.GetString(Convert.FromBase64String(encripted.Replace("\n", "")));

        public bool identify(string encripted) => Regex.Match(encripted.Replace("\n", ""), "^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$").Success;

        public string name() => "Base64";
    }
}
