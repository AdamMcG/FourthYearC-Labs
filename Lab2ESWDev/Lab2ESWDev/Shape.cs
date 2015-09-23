using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ESWDev
{
public class Shape
    {
        public string ShapeColour { get; set; }

        public Shape(string shapeColour)
        {
            if (shapeColour != null)
            {
                this.ShapeColour = shapeColour;
            }
        }

        public Shape() : this(" ")
        {
        }

        public virtual void Translate(Vertex tranlated)
        {

        }

        public override string ToString()
        {
            return "ShapeColour: " + ShapeColour +"\n";
        }
    }
}
