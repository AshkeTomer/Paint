using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.shapes
{
    [Serializable]
    class MyRectangle : Polygon
    {
        public MyRectangle(Point point)
        {
            this.point = new Point(point.X, point.Y);
            corners = 4;
        }

        public override void draw(Graphics g, Pen pen, int sX, int sY)
        {
            g.DrawRectangle(pen ,point.X, point.Y, sX, sY);
        }
    }
}

