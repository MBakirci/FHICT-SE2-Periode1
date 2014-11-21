using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _7._4._2_Shapes
{
    class Square : Shape
    {
        private double size;
        public override double Area
        {
            get { return size * size; }
        }

        public Square(Point position, Color color, double size) : base (position,color)
        {
            this.position = position;
            this.color = color;
            this.size = size;
        }

        public override string ToString()
        {
            return "Square" + ", " + base.ToString();
        }
    }
}
