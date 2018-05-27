using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApplication
{
    public class Triangle : Shape
    {

        private int a, b, c;

        public Triangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("No edges should be negative or zero");
            else
            {

                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public int getA()
        {
            return a;
        }
        public int getB()
        {
            return b;
        }
        public int getC()
        {
            return c;
        }


        public override double area()
        {
            double p;
            double s;
            double result = RightTriangle();

            if (result == 0)
            {
                p = (a + b + c) / 2;

                s = (p - a) * (p - b) * (p - c) * p;
                s = Math.Sqrt(s);
                return s;
            }
            else return result;
        }

        public double RightTriangle()
        {
            int max;
            int temp1, temp2;
            if (a > b && a > c)
            {
                max = a;
                temp1 = b;
                temp2 = c;

            }
            else if (b > a && b > c)
            {
                max = b;
                temp1 = a;
                temp2 = c;
            }
            else
            {
                max = c;
                temp1 = a;
                temp2 = b;
            }

            if (max * max == temp1 * temp1 + temp2 * temp2)
                return temp1 * temp2 / 2;
            else
                return 0;

        }

    }
}
