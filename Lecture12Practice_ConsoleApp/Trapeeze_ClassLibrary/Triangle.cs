using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeeze_ClassLibrary
{
    public class Triangle : Figure
    {
        public override double Area
        {
            get
            {
                return 0.5 * MathCalc.GetLength(Points[0], Points[2]) * (Points[1].Y - Points[0].Y);
            }
        }

        public override bool CheckIsosceles
        {
            get
            {
                return (MathCalc.GetLength(Points[0], Points[1]) == MathCalc.GetLength(Points[1], Points[2]));
            }
        }

        public Triangle(Point[] points) : base(points)
        {
            if (points.Length > 3)
            {
                throw new Exception("Can take array of 3 doubles");
            }
        }

        public override string TypeOfFigure()
        {
            string result = "";
            if (Points.Length > 2)
            {
                result = "Figure is triangle";
            }
            return result;
        }
    }
}
