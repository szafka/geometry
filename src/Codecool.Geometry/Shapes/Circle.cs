using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        private readonly double r;
        public const double PI = 3.1415926535897931;
        public Circle (double r)
        {
            this.PI = PI;
            this.r = r;
        }
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public new static string AreaFormula => Console.WriteLine("Area = PI * r^2");

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public new static string PerimeterFormula => Console.WriteLine("Perimeter = 2*PI*r");

        /// <inheritdoc />
        public override double Area => PI*r*r;
        /// <inheritdoc />
        public override double Perimeter => 2*PI*r;
    }
} 
