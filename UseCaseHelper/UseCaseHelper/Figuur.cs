using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    public class Figuur
    {
        private string soort;
        private int x;
        private int y;
        private int h;
        private int w;
        private Point p1;
        private Point p2;

        public string Soort
        {
            get
            {
                return soort;
            }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public int H
        {
            get { return h; }
        }

        public int W
        {
            get { return w; }
        }

        public Point P1
        {
            get { return p1; }
        }

        public Point P2
        {
            get { return p2; }
        }
        public Figuur(string Soort, int X, int Y, int H, int W)
        {
            this.soort = Soort;
            this.x = X;
            this.y = Y;
            this.h = H;
            this.w = W;

        }
        public Figuur(string Soort, Point P1, Point P2 )
        {
            this.soort = Soort;
            this.p1 = P1;
            this.p2 = P2;
        }
    }
}
