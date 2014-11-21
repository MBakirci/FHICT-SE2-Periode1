using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4._1_Animals
{
    class Dog : Animal
    {
        private string noise;
        public Dog(string name): base (name)
        {
            this.name = name;
        }

        public override void MakeNoise()
        {
            noise = "WAFWAFWAF";
        }

        public override string ToString()
        {
            return name + ", " + noise;
        }
    }
}
