using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeeze_ClassLibrary
{
    public class Trapezoid : Figure
    {
        public override double Area
        {
            get
            {
                return 0.5 * (MathCalc.GetLength(Points[1], Points[2]) + MathCalc.GetLength(Points[0], Points[3])) * (Points[1].Y - Points[0].Y);
            }
        }

        public override bool CheckIsosceles 
        {
            get
            {
                return (MathCalc.GetLength(Points[0], Points[2]) == MathCalc.GetLength(Points[3], Points[1]));
            }
        }
        public Trapezoid(Point[] points) : base(points)
        {
            if (points.Length > 4)
            {
                throw new Exception("Can take array of 4 doubles");
            }
        }

        public override string TypeOfFigure()
        {
            string result;
            if (MathCalc.GetLength(Points[0], Points[2]) == MathCalc.GetLength(Points[1], Points[3]))
            {
                result = "Figure is square";
            }
            else
            {
                result = "Some sort of tetragon";
            }
            return result;
        }
    }
}
