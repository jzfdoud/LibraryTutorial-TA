using System;
using System.Collections.Generic;
using System.Text;

namespace TestMathLib_TA
{
    public static class MathLibExtensions
    {
        public static int Squared(this int x)
        {
            return x * x;
        }

        public static int Power(this int x, int y)
        {
            var answer=1;
            for(int idx=0; idx < y ;idx++)
            {
                answer *= x;
            }
            return answer;
        }

        public static void Print (this string s)
        {
            Console.WriteLine($"{s}");
        }
    }
}
