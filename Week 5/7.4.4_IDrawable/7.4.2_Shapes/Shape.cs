using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _7._4._4_Shapes
{
    abstract class Shape : IDrawable
    {
        protected Point position;
        protected Color color;

        public Point Position { get { return position; } set { position = value; } }
        public Color Color { get { return color; } set { color = value; } }
        public abstract double Area {get;}

        public Shape(Point position, Color color )
        {
            this.position = position;
            this.color = color;
        }

        public override string ToString()
        {
            return position + ", " + color + ", " + Area.ToString();
        }

        public abstract void DrawTo(Graphics drawingSurface);

    }
}
