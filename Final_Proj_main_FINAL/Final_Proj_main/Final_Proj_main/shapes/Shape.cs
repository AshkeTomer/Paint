using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.shapes
{
    [Serializable]
    public abstract class Shape : Figures
    {
     
        protected Point point;

        public float getX()
        {
           return point.X;
        }

        public float getY()
        {
            return point.Y;
        }

        public void setX(int x)
        {
            point.X = x;
        }

        public void setY(int y)
        {
            point.Y = y;
        }

        public abstract void draw(Graphics g, Pen pen, int sX, int sY);
    }
}
