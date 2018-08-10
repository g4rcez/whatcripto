using System;
using System.Collections.Generic;
using Whatcripto.ciphers;

namespace Whatcripto {
    class Program {
        private static List<CipherDetect> ciphers = new List<CipherDetect>();

        private static Boolean ciphersWithoutKey(string args) => args.Contains("-k") || args.Contains("--key");

        private static void load() {
            ciphers.Add(new Base64());
            ciphers.Add(new BaconianCipher());
            ciphers.Add(new BinaryCode());
            ciphers.Add(new HackerizeXS());
            ciphers.Add(new MorseCode());
            ciphers.Add(new CesarCipher());
        }

        static void Main(params string[] args) {
            string @string = String.Join(" ", args);
            if (ciphersWithoutKey(@string)) {
                // Load list with key for decipher
            } else {
                load();
            }
            ciphers.ForEach(cipher => {
                if (cipher.identify(@string)) {
                    Console.WriteLine($"{cipher.name()} => {cipher.cleanText(@string)}");
                }
            });
        }
    }
}
