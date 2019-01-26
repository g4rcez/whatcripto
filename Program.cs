using System.Text;
using System;
using System.Collections.Generic;
using whatcripto.ciphers;
using whatcripto.utils;

namespace Whatcripto
{
    class Program
    {
        private static List<CipherDetect> ciphers = new List<CipherDetect>();

        private static Boolean ciphersWithoutKey(string args) => args.Contains("-k") || args.Contains("--key");

        private static void load()
        {
            ciphers.Add(new Base64());
            ciphers.Add(new Base32());
            ciphers.Add(new BaconianCipher());
            ciphers.Add(new BinaryCode());
            ciphers.Add(new HackerizeXS());
            ciphers.Add(new MorseCode());
            ciphers.Add(new RailFenceCipher());
            ciphers.Add(new CesarCipher());
        }

        private static void loadWithKey(string key)
        {
            ciphers.Add(new VigenereCipher(key));
            ciphers.Add(new XorCipher(key));
        }

        private static void help(string @string)
        {
            if (@string.Contains("-h") || @string.Contains("--help"))
            {
                Console.WriteLine(HelpMe.maintainer());
                System.Environment.Exit(1);
            }
        }

        static void Main(string[] args)
        {
            string @string = String.Join(" ", args);
            help(@string);
            if (ciphersWithoutKey(@string))
            {
                string[] values = @string.Split(" ");
                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i].Equals("-k") || values[i].Equals("--key"))
                    {
                        loadWithKey(values[i + 1]);
                        List<string> list = new List<string>(values);
                        list.Remove(values[i]);
                        list.Remove(values[i + 1]);
                        @string = String.Join(" ", list.ToArray());
                        break;
                    }
                }
            }
            else
            {
                load();
            }
            ciphers.ForEach(cipher =>
            {
                if (cipher.identify(@string))
                {
                    Console.WriteLine($"{cipher.name()} => {cipher.cleanText(@string)}\n");
                }
            });
        }
    }
}
