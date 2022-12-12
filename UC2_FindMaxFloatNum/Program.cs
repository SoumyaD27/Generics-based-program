using System;
using UC2_FindMaxFloatNum;

namespace UC2_FindMaxFloatNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Float Number");

            double output = MaximumNumberCheck.MaximumFloatNumber( 3.1, 1.2, 1.3);
            Console.WriteLine(output);
        }
    }
}