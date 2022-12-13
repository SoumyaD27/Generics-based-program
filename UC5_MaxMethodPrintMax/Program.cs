using System;
namespace UC5_MaxMethodPrintMax
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
        public class Program
        {
            public static void Main(string[] args)
            {
                int[] arr = { 112, 344, 435, 777, 987 };
                GenericMaximum<int> generic = new GenericMaximum<int>(arr);
                generic.PrintMaxValue();

            }
        }
    
}