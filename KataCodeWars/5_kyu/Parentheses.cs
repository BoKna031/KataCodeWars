using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodeWars._5_kyu
{
    // challenge https://www.codewars.com/kata/52774a314c2333f0a7000688/train/csharp
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            int counter = 0;
            foreach (char c in input)
            {
                if (c == '(')
                { 
                    counter++;
                }else if(c == ')')
                {
                    counter--;
                }

                if (counter < 0)
                    return false;
            }
            return counter == 0;
        }
    }
}
