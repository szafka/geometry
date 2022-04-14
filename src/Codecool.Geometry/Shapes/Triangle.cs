using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        protected readonly double a;
        protected readonly double b;
        protected readonly double c;

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
        public override string ToString()
        {
            return String.Format("Square, a = {0}" + a);
        }
}
}
