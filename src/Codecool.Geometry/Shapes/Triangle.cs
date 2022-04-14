using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "Area = sqrt(s×(s-a)×(s-b)×(s-c))";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "Perimeter = a + b + c";

        /// <inheritdoc/>
        public override double Perimeter => a + b + c;

        /// <inheritdoc />
        public override double Area
        {
            get 
            { 
                double s = Perimeter / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }
    }
}
