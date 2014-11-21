using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _7._4._4_Shapes
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

        public override void DrawTo(Graphics drawingSurface)
        {

            Pen p = new Pen(color);
            Size s = new Size(Convert.ToInt32(size), Convert.ToInt32(size));
            Rectangle r = new Rectangle(position, s);
            drawingSurface.DrawRectangle(p, r);
        }
    }
}
