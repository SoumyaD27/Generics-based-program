using System;
using UC3_FindMaxString;

namespace UC3_FindMaxStringNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max String Number");

            string output = MaximumNumberCheck.MaximumStringNumber("22","33","44");
            Console.WriteLine(output);
        }
    }
}