using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata
{
    public class RomanNumeral
    {
        public string IntToRoman(int num)
        {
            string romanResult = "";
            Dictionary<string, int> romanNumbersDictionary = new()
            {
                {
                    "I",
                    1
                },
                {
                    "IV",
                    4
                },
                {
                    "V",
                    5
                },
                {
                    "IX",
                    9
                },
                {
                    "X",
                    10
                },
                {
                    "XL",
                    40
                },
                {
                    "L",
                    50
                },
                {
                    "XC",
                    90
                },
                {
                    "C",
                    100
                },
                {
                    "CD",
                    400
                },
                {
                    "D",
                    500
                },
                {
                    "CM",
                    900
                },
                {
                    "M",
                    1000
                }
            };
            foreach (var item in romanNumbersDictionary.Reverse())
            {
                if (num <= 0) break;
                while (num >= item.Value)
                {
                    romanResult += item.Key;
                    num -= item.Value;
                }
            }
            return romanResult;
        }
        public int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }
    }
}
