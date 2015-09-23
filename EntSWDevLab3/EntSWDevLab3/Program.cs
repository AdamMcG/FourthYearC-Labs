using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab3
{
    class Program
    {
        static void Main()
        {
            IHasVolume v = new Sphere(1333);
            Console.WriteLine(v.ToString());
            IHasVolume v2 = new Sphere(1);
            Console.WriteLine(v2.ToString());
            List<IHasVolume> listOfSphere = new List<IHasVolume>();
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
                listOfSphere.Add(new Sphere(2*i));
               Console.WriteLine(listOfSphere[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
