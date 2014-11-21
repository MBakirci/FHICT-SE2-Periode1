using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _7._4._4_Shapes
{
    class Circle : Shape
    {
        private double radius;
        public override double Area
        {
            get { return Math.PI * radius * radius; }
        }

        public Circle(Point position, Color color, double radius) : base (position,color)
        {
            this.position = position;
            this.color = color;
            this.radius = radius;

        }

        public override string ToString()
        {
            return "Cirkel" + ", " + base.ToString();
        }

        public override void DrawTo(Graphics drawingSurface)
        {
            Pen p = new Pen(color);
            Size s = new Size(Convert.ToInt32(radius),Convert.ToInt32(radius));
            Rectangle r = new Rectangle(position, s);
            drawingSurface.DrawEllipse(p,r);
        }
    }
}
