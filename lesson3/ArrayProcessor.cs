using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public class ArrayProcessor
    {
        public static void ProcessArray(int[] array, Action<int> processor)
        {
            foreach (int item in array)
            {
                processor(item);
            }
        }
    }

    public class SumCalculator
    {
        private int _sum;

        public void AddToSum(int number)
        {
            _sum += number;
        }

        public int GetSum()
        {
            return _sum;
        }

    }

    public class MaxCalculator
    {
        private int _max;

        public void CalculatMax(int number) 
        {
            if(number > _max)
            {
                _max = number;
            }
        }

        public int GetMax()
        {
            return _max;
        }
    }
}
