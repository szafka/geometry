using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        protected readonly double a;
        protected readonly double b;
        
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => "a * b";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "2a * 2b";

        /// <inheritdoc />
        public override double Area => a * b;

        /// <inheritdoc />
        public override double Perimeter => 2*a * 2*b;
        public override string ToString()
        {
            return String.Format("Rectangle, a = {0}, b = {1}",a,b);
        }
    }
}
