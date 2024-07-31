using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.shapes
{
    [Serializable]
    class Circle : Shape
    {
        float radius;
        

        public Circle(Point point)
        {
            this.point = new Point(point.X, point.Y);
        }

        public void setRadius(float _radius)
        {
            radius = _radius;
        }

        public float getRadius()
        {
            return radius;
        }

        ~Circle()
        {
        }

        public override void draw(Graphics g, Pen pen, int sX, int sY)
        {
            g.DrawEllipse(pen, point.X, point.Y, sX, sY);
        }
    }
}
