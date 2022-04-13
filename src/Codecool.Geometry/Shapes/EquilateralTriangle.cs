using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        private readonly double h;
        public EquilateralTriangle(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = a;
            this.c = a;
            this.h = h;
        }
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => Console.WriteLine("0,5 * a * h");

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => Console.WriteLine("3*a");
    }
}
