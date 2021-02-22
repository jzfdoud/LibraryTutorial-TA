using System;

using LibraryTutorial_TA;

namespace TestMathLib_TA
{
    class Program
    {
        static void Main(string[] args)
        {


            var mathLib = new MathLib();

            Console.WriteLine($" About: {mathLib.About}");

            // MathLib practice contd. Created math functions in MathLib.cs

            Console.WriteLine($"12 + 3 = {mathLib.Add(12, 3)}");
            Console.WriteLine($"12 - 3 = {mathLib.Subtract(12, 3)}");
            Console.WriteLine($"12 * 3 = {mathLib.Multiply(12, 3)}");
            Console.WriteLine($"12 / 3 = {mathLib.Divide(12, 3)}");
            Console.WriteLine($"12 % 3 = {mathLib.Modulo(12, 3)}");
            Console.WriteLine($"12 ^ 3 = {mathLib.Power(12, 3)}");

            //MathLib practice. Extension Method example
            Console.WriteLine($" 3 squared is {3.Squared()}");
            Console.WriteLine($" 2 ^ 3 is {2.Power(3)}");

            "This is a test".Print();

        }
    }
}
