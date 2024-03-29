﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4._1_Animals
{
    abstract class Animal
    {
        protected string name;

        public string Name { get { return name; } set { name = value; } }

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeNoise();
    }
}
