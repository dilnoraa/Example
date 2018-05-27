using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int r)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("Radius must be positif");
            else
                radius = r;
        }

      

        public int getRadius()
        {
            return radius;
        }

        public override double area()
        {
            double pi = 3.14;
            return  pi * radius * radius;
        }

    }
}
