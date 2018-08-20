using System;
using System.Collections.Generic;
using whatcripto.utils;

namespace whatcripto.ciphers {
    public class RailFenceCipher : CipherDetect {
        public string cleanText(string encripted) {
            List<string> bruteFroce = new List<string>();
            for (int i = 0; i <= 26; i++) {
                try {
                    bruteFroce.Add(oneRail(encripted, i));
                } catch (System.Exception) {}
            }
            return String.Join("\t|=> ", bruteFroce);
        }

        public bool identify(string encripted) => Strings.plusThen4(encripted);

        public string name() => "RailFence";

        private string oneRail(string encripted, int rail) {
            int Length = encripted.Length;
            List<List<int>> Map = new List<List<int>>();
            for (int i = 0; i < rail; i++)Map.Add(new List<int>());
            int Iterator = 0;
            int Increment = 1;
            for (int i = 0; i < Length; i++) {
                if (Iterator + Increment == rail) {
                    Increment = -1;
                } else if (Iterator + Increment == -1) {
                    Increment = 1;
                }
                Map[Iterator].Add(i);
                Iterator += Increment;
            }
            int counter = 0;
            char[] buffer = new char[Length];
            for (int i = 0; i < rail; i++) {
                for (int j = 0; j < Map[i].Count; j++) {
                    buffer[Map[i][j]] = encripted[counter];
                    counter++;
                }
            }
            return new string(buffer);
        }
    }
}
