using System;
using System.Collections.Generic;

namespace Lab1ESWDev
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ThreeDShape myShape = new Sphere("Sphere", 33);
            ThreeDShape myShape2 = new Sphere("Sphere", -12.3);
            Console.WriteLine(myShape.ToString());
            Console.WriteLine(myShape2.ToString());
            var listOfShapes = new List<ThreeDShape>();
            for (var i = 0; i < 10; i++)
            {
                listOfShapes.Add(new Sphere("Sphere" + i, 3*i));
            }
            foreach (var t in listOfShapes)
            {
                Console.WriteLine(t.ToString());
            }
            Console.ReadLine();
        }
    }
}