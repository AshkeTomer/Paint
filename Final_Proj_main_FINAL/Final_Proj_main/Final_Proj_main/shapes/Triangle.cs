using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.shapes
{
    [Serializable]
    class Triangle : Polygon
    {
        int degrees;

        public Triangle(Point point)
        {
            this.point = point;
            degrees = 180;
            corners = 3;
        }

        public int getDegrees()
        {
            return degrees;
        }

        ~Triangle()
        {
        }

        public override void draw(Graphics g, Pen pen, int sX, int sY)
        {
            double xMid = (point.X + sX) / 2;

            Point first = point;
            Point mid = new Point((int)xMid, sY);
            Point end = new Point(sX, sY);
            
            g.DrawLine(pen,first, mid);
            g.DrawLine(pen,first,end);
            g.DrawLine(pen,end, mid);
        }
    }
}
