using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._3_Icomparable
{
    class SortByNumber : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(x.Number < y.Number)
            {
                return -1;
            }
            else if(x.Number > y.Number)
            {
                return 1;
            }
            else return 0;
        }

        
    }
}
