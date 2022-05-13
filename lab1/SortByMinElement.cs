using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class SortByMinElement:IBaseAlgorithm
    {
        public int Handle(int[] row)
        {
            return row.Min();
        }
    }
}
