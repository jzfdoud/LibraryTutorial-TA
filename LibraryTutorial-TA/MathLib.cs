using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTutorial_TA
{
    public class MathLib
    {
        public string About { get; set; } = "About MathLib";
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public int Modulo(int x, int y)
        {
            return x - (x / y * y);
        }
        public int Power(int x, int y)
        {
            var answer = 1;
            for(int idx=0; idx < y; idx++)
            {
                answer *= x;
            }
            return answer;
        }

    }
}
