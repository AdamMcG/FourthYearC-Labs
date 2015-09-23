using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ESWDev
{
    public class Circle : Shape
    {
        public Vertex Origin { get; set; }
        public int Radius { get; set; }
        public Circle() : this(0, 0, 0, string.Empty)
        {
        }

        public Circle(int originPointX, int originPointY, int radius, string shapeColour) : base(shapeColour)
        {
            Origin = new Vertex(originPointX, originPointY);
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override void Translate(Vertex tranlated)
        {
            if (tranlated != null)
            {
                Origin.PointX = Origin.PointX + tranlated.PointX;
                Origin.PointY = Origin.PointY + tranlated.PointY;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Radius: " + Radius + "\nOrigin: (" + Origin.PointX + "," + Origin.PointY + ")\n Area: " + Area();
        }
    }
}
