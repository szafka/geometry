using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        private readonly double r;
        public Circle(double r)
        {
            this.r = r;
        }
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new static string AreaFormula => "PI * r^2";

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public new static string PerimeterFormula => "2*PI*r";

        /// <inheritdoc />
        public override double Area => Math.PI *r*r;
        /// <inheritdoc />
        public override double Perimeter => 2*Math.PI *r;

        public override string ToString()
        {
            return String.Format("Circle, r = {0}", r);
        }
    }
} 
