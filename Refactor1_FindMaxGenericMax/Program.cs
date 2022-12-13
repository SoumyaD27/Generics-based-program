using System;
namespace Refactor1_FindMaxNumGenericClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");

            int[] intArray = { 112, 113, 444, 345 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 11.2, 1.13, 4.44, 34.5 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "Apple", "Peach", "Mango"};
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();

        }
    }
}