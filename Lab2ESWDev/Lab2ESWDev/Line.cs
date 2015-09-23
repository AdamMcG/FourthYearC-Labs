using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ESWDev
{
    public class Line : Shape
    {
        public Vertex HeadVertex { get; set; }
        public Vertex TailVertex { get; set; }
        public Line()
        {
        }

        public Line(int headPointX, int headPointY, int tailPointX, int tailPointY, string shapeColour) : base(shapeColour)
        {
            HeadVertex = new Vertex(headPointX, headPointY);
            TailVertex = new Vertex(tailPointX, tailPointY);
        }

        public override void Translate(Vertex translater)
        {
            if (translater == null) return;
            HeadVertex.PointX = HeadVertex.PointX + translater.PointX;
            HeadVertex.PointY = HeadVertex.PointY + translater.PointY;
            TailVertex.PointX = HeadVertex.PointX + translater.PointX;
            TailVertex.PointY = HeadVertex.PointY + translater.PointY;
        }

        public override string ToString()
        {
            return base.ToString() + "HeadVertex: (" + HeadVertex.PointX + "," + HeadVertex.PointY + ")\n TailVertex: (" + TailVertex.PointX + "," + TailVertex.PointY + ")";
        }
    }
}
