using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._3_Icomparable
{
    class Student : IComparable<Student>
    {
        private string name;
        private string address;
        private int number;

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Number { get { return number; } set { number = value; } }

        public Student(string name, string address, int number)
        {
            this.name = name;
            this.address = address;
            this.number = number;
        }

        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return name + ", " + address + ", " + number;
        }
    }
}
