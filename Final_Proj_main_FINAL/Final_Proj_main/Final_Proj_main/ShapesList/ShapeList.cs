using Final_Proj_main.shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proj_main.ShapesList
{
    [Serializable]

    public class ShapeList : SortedList
    {
        public int NextIndex
        {
            get
            {
                return this.Count;
            }
        }
    }
}
