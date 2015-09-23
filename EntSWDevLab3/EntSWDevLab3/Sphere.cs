using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab3
{
     public class Sphere : IHasVolume
    {

         public Sphere(double radius)
         {
             SphereRadius = radius;
         }

         public Sphere() : this(0)
         {
         }

         private double sphereRadius;
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
            return "Sphere:"+ "\nRadius " + SphereRadius
                   + "\nVolume: " + GetVolume();
        }

        public double GetVolume()
        {
            return Math.PI*(Math.Pow(SphereRadius, 3));
        }
    }
}
