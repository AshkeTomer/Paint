using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.shapes
{
    [Serializable]
    abstract class Polygon : Shape
    {
        protected int corners;

        public int getCorners()
        {
            return corners;
        }

        public void setCorners(int s)
        {
            corners = s;
        }
        public abstract override void draw(Graphics g, Pen pen, int sX, int sY);
    }
}
