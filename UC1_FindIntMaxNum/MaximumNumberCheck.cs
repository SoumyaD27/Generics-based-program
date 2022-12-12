using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_FindIntMaxNum
{
    public class MaximumNumberCheck
    {
        public static int MaximumIntNumber(int firstValue, int secondValue, int thirdValue)
        {
            if(firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if(secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue)>0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstNumber,SecondNumber,ThirdNumber are same");
            
        }
    }
}
