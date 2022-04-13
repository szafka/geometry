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
        private readonly double h;
        
        public Triangle(double a, double b, double c, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;
        }
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => Console.WriteLine("Area = 0,5 * a * h");

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => Console.WriteLine("Perimeter = a + b + c");

        /// <inheritdoc/>
        public override double Perimeter => a + b + c;

        /// <inheritdoc />
        public override double Area => 0,5 * a * h;
    }
}
