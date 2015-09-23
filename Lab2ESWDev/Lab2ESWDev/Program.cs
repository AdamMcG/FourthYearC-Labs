using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2ESWDev
{
    class Program
    {
        static void Main()
        {
            Shape myShape = new Line(2,2,3,3,"Red");
            Console.WriteLine("shape1");
            Console.WriteLine(myShape.ToString());
            myShape.Translate(new Vertex(1,1));
            Console.WriteLine(myShape.ToString());
            Console.WriteLine("\nShape2");
            Shape myShape2 = new Circle(3,4,1,"blue");
            Console.WriteLine(myShape2.ToString());
            Console.ReadLine();
        }
    }
}
