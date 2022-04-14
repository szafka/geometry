using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a){}
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "a×a×sqrt(3)/4";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "3*a";
        public override string ToString()
        {
            return String.Format("Equilateral Triangle, a = {0}" + a);
        }
    }
}
