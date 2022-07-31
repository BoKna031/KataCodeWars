using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodeWars
{
    // challenge https://www.codewars.com/kata/51b66044bce5799a7f000003/train/csharp
    public class RomanNumeralsHelper
    {

        private static readonly string[] signs = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        private static readonly int[] values = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        public static string ToRoman(int n)
        {
            int index = signs.Length - 1;
            StringBuilder result = new();
            while(n > 0)
            {
                if(n < values[index])
                {
                    index--;
                }
                else
                {
                    result.Append(signs[index]);
                    n -= values[index];
                }
            }
            return result.ToString();
        }

        public static int FromRoman(string romanNumeral)
        {
            int result = 0;
            while(romanNumeral.Length > 0)
            {
                string num = IsDoubleCharRomanSign(romanNumeral) ? romanNumeral[..2] : romanNumeral[0].ToString();

                int inx = Array.IndexOf(signs, num);
                result += values[inx];

                romanNumeral = romanNumeral[num.Length..];
            }
            return result;
        }

        private static bool IsDoubleCharRomanSign(string romanNumeral)
        {
            return romanNumeral.Length > 1 && Array.IndexOf(signs, romanNumeral[0].ToString()) < Array.IndexOf(signs, romanNumeral[1].ToString());
        }
    }
}
