using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ESWDev
{
    public class Vertex
    {
        public int PointX { get; set; }
        public int PointY { get; set; }
        public Vertex(int pointX, int pointY)
        {
            this.PointX = pointX;
            this.PointY = pointY;
        }
        public Vertex()
        :this(0,0)
        {
        }

    }
}
