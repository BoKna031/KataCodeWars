using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataCodeWars
{
    //challenge https://www.codewars.com/kata/5513795bd3fafb56c200049e/train/csharp
    public static class CountByX
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            int index = 0;
            for (int i = x; i <= x * n; i = i + x, index++)
            {
                z[index] = i;
            }

            return z;
        }
    }
}
