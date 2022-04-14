using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        private readonly double a;

        private readonly double h;
        public EquilateralTriangle(double a, double h) : base(a, a, a, h)
        {
            this.a = a;
            this.h = h;
        }
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "0.5 * a * h";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "3*a";
    }
}
