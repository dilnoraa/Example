using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            try
            {
                shapes.Add(new Circle(5));
                // shapes.Add(new Circle(-5));
                shapes.Add(new Triangle(3, 4, 5));
                shapes.Add(new Circle(9));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (Shape p in shapes)
            {
               
                Console.Write("Area of " + p.GetType().Name + " is " );
                Console.WriteLine(p.area());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
