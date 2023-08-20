using System;

namespace _52_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cube cube = new Cube(15);
            cube.GetInfo();

            Sphere sphere = new Sphere(15);
            sphere.GetInfo();
            */

            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }
                
                if(iceCube is Cube)
                {
                    Console.WriteLine("This is a cube!");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} Has a volume of {1}", cube2.Name, cube2.Volume());

            }

        }
    }
}
