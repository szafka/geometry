using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        public Square(double a) : base(a, a){}
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => "a * a";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "4*a";
        public override string ToString()
        {
            return String.Format("Square, a = {0}", a);
        }
    }
}
