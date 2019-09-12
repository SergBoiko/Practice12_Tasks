using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeeze_ClassLibrary
{
    public static class MathCalc
    {
        public static double GetLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.X - B.X), 2));
        }
    }
}
