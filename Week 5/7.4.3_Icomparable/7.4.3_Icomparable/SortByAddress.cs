using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._3_Icomparable
{
    class SortByAddress : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Address.CompareTo(y.Address);
        }
    }
}
