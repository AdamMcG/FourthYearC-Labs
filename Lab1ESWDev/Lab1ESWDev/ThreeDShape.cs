using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ESWDev
{
    abstract class ThreeDShape
    {
        private readonly string shapeType;

        public string ShapeType => shapeType;

        private ThreeDShape()
        {
            shapeType = null;
        }

        public ThreeDShape(string shape)
        {
            shapeType = shape;
        }

        public override string ToString()
        {
            return "ShapeType:" +  ShapeType.ToString();
        }

        public abstract double GetVolume();
    }
}
