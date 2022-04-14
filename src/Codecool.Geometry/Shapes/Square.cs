using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        private readonly double a;
        private readonly double b;

        public Square(double a) : base(a, a)
         {

         }
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => "Area = a^2";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "Perimenter = 4*a";
    }
}
