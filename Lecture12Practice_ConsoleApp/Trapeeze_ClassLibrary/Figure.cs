using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeeze_ClassLibrary
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    public abstract class Figure
    {
        public Point[] Points { get; set; }
        protected Figure()
        {

        }

        public Figure(Point[] points)
        {
            Points = points;
        }

        public virtual bool CheckIsosceles
        {
            get
            {
                return false;
            }
        }

        public virtual double Area
        {
            get
            {
                return 0.0;
            }
        }

        public double Perimeter
        {
            get
            {
                double result = 0;
                for (int i = 0; i < Points.Length; i++)
                {
                    if (i < Points.Length - 1)
                    {
                        result += MathCalc.GetLength(Points[i], Points[i + 1]);
                    }
                    else
                    {
                        result += MathCalc.GetLength(Points[i], Points[0]);
                    }
                }
                return result;
            }
        }
        public void Drawing()
        {
        }
        public abstract string TypeOfFigure();

        public override string ToString()
        {
            return $"{TypeOfFigure()}, Area = {Area}, Perimeter = {Perimeter}";

        }
    }
}
