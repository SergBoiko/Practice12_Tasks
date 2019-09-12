using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trapeeze_ClassLibrary;

namespace Lecture12Practice_ConsoleApp
{
    public class Program
    {      
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            do
            {
                Console.WriteLine("Choose task [1] - figures [2] - circle [3] - info ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter number of figures");
                        int amount = int.Parse(Console.ReadLine());

                        for (int i = 0; i < amount; i++)
                        {
                            Console.WriteLine("Choose a figure:");
                            Console.WriteLine("1 - Triangle");
                            Console.WriteLine("2 - Trapezoid");
                            int figure = int.Parse(Console.ReadLine());

                            switch (figure)
                            {
                                case 1:
                                    Point[] pointsTriangle = new Point[3];
                                    for (int tr = 0; tr < 3; tr++)
                                    {
                                        Console.WriteLine($"Koordinati {tr + 1} tochki:");
                                        Console.Write("X = ");
                                        pointsTriangle[tr].X = int.Parse(Console.ReadLine());
                                        Console.Write("Y = ");
                                        pointsTriangle[tr].Y = int.Parse(Console.ReadLine());
                                    }
                                    Triangle triangle = new Triangle(pointsTriangle);
                                    figures.Add(triangle);
                                    break;
                                case 2:
                                    Point[] pointsTrapez = new Point[4];
                                    for (int trap = 0; trap < 4; trap++)
                                    {
                                        Console.WriteLine($"Koordinat {trap + 1} tochki:");
                                        Console.Write("X = ");
                                        pointsTrapez[trap].X = int.Parse(Console.ReadLine());
                                        Console.Write("Y = ");
                                        pointsTrapez[trap].Y = int.Parse(Console.ReadLine());
                                    }
                                    Trapezoid trapezoid = new Trapezoid(pointsTrapez);
                                    figures.Add(trapezoid);
                                    break;
                            }
                        }

                        double[] area = new double[amount];

                        int numberOfTrap = 0;
                        foreach (var figure in figures)
                        {
                            Console.WriteLine($"{numberOfTrap + 1} {nameof(figure)} Isosceles = {figure.CheckIsosceles}, Area = {figure.Area}, Perimeter = {figure.Perimeter}");
                            area[numberOfTrap] = figure.Area;
                            numberOfTrap++;
                        }

                        double avgArea= area.Sum() / area.Length;

                        int amountAboveAvg = 0;

                        for (int i = 0; i < area.Length; i++)
                        {
                            if (area[i] > avgArea)
                            {
                                amountAboveAvg++;
                            }
                        }
                        Console.WriteLine($"Amount of figures with Area above average = {amountAboveAvg}");
                        Console.WriteLine();
                        break;
                    case 2:

                        for (int i = 0; i < 2; i++)
                        {
                            int figure = 0;
                            Console.WriteLine("Choose figure to create - circle or elipse");
                            do
                            {
                                Console.Write("1 - circle, 2 - elipse");
                            } while (!int.TryParse(Console.ReadLine(), out figure) || figure == 0);
                            switch (figure)
                            {
                                case 1:
                                    Console.WriteLine($"Points of {i + 1}st circle");
                                    Console.Write("X = ");
                                    double pointX = double.Parse(Console.ReadLine());
                                    Console.Write("Y = ");
                                    double pointY = double.Parse(Console.ReadLine());
                                    Point centerofCircle = new Point(pointX, pointY);
                                    Console.Write("radius = ");
                                    double radius = double.Parse(Console.ReadLine());

                                    figures.Add(new Circle(centerofCircle, radius, radius));
                                    break;
                                case 2:
                                    Console.WriteLine($"Points of {i + 1}st elipse");
                                    Console.Write("X = ");
                                    double pointXel = double.Parse(Console.ReadLine());
                                    Console.Write("Y = ");
                                    double pointYel = double.Parse(Console.ReadLine());
                                    Point centerOfElipse = new Point(pointXel, pointYel);
                                    Console.Write("1s radius = ");
                                    double radius1 = double.Parse(Console.ReadLine());
                                    Console.Write("2nd radius = ");
                                    double radius2 = double.Parse(Console.ReadLine());

                                    figures.Add(new Circle(centerOfElipse, radius1, radius2));
                                    break;
                            }
                        }
                        break;
                    case 3:
                        int numberOfFigures = 0;
                        foreach (var figure in figures)
                        {
                            Console.WriteLine(figure.ToString());
                            numberOfFigures++;
                        }
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
