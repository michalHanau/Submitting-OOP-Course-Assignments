using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    public class GenericOperationTable<T>
    {
        public delegate T OpFunc(T x, T y);

        private List<T> rowValues;
        private List<T> colValues;
        private T[,] table;

        public GenericOperationTable(List<T> _rowValues, List<T> _colValues, OpFunc op)
        {
            rowValues = _rowValues;
            colValues = _colValues;
            table = new T[rowValues.Count, colValues.Count];

            for (int i = 0; i < rowValues.Count; i++)
            {
                for (int j = 0; j < colValues.Count; j++)
                {
                    table[i, j] = op(rowValues[i], colValues[j]);
                }
            }
        }

        public void Print()
        {
            Console.Write("     ");
            foreach (var col in colValues)
            {
                Console.Write($"{col,10}");
            }
            Console.WriteLine();

            for (int i = 0; i < rowValues.Count; i++)
            {
                Console.Write($"{rowValues[i],5}");
                for (int j = 0; j < colValues.Count; j++)
                {
                    Console.Write($"{table[i, j],10}");
                }
                Console.WriteLine();
            }
        }
    }
}
