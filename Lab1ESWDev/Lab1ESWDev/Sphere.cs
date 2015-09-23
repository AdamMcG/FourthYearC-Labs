using System;

namespace Lab1ESWDev
{
    internal class Sphere : ThreeDShape
    {
        private double sphereRadius;

        public Sphere(string shape) : base(shape)
        {
            SphereRadius = 0;
        }

        public Sphere(string shape, double radius) : base(shape)
        {
            SphereRadius = radius;
        }

        public double SphereRadius
        {
            get { return sphereRadius; }
            set
            {
                if (value >= 0)
                    sphereRadius = value;
            }
        }

        public override string ToString()
        {
            return "Shape: " + ShapeType +
                   "\nRadius " + SphereRadius
                   + "\nVolume:" + GetVolume();
        }

        public override double GetVolume()
        {
            return Math.PI*(Math.Pow(SphereRadius, 3));
        }
    }
}