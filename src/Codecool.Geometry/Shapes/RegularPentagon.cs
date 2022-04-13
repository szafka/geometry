using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        private readonly double a;
        private readonly double n;

        public RegularPentagon(double a, double n)
        {
            this.a = a;
            this.n = n;
        }

        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => Console.WriteLine("(n/2)*((a/2)*cosec(PI/n)^2)*sin(2PI/n)");

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => Console.WriteLine("Perimental = 5*a");

        /// <inheritdoc/>
        public override double Area => (n/2)*(((a/2)*1/(Math.SIN(Math.PI/n))^2)*Math.SIN(2*Math.PI/n);

        /// <inheritdoc/>
        public override double Perimeter => 5*a;
    }
}
