using System;
namespace UC1_FindIntMaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Int Number");
       
            int output = MaximumNumberCheck.MaximumIntNumber(11, 12, 13);
            Console.WriteLine(output);
        }
    }
}