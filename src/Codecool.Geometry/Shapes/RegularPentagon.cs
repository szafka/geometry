using System;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        protected readonly double a;

        public RegularPentagon(double a)
        {
            this.a = a;
        }

        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => "(n/2)*((a/2)*cosec(PI/n)^2)*sin(2PI/n)";

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => "5*a";

        /// <inheritdoc/>
        public override double Area => (Math.Sqrt(25 + 10*Math.Sqrt(5)))*Math.Pow(a, 2)/4;
            
            //(n/2)*(((a/2)*1/(Math.SIN(Math.PI/n))^2)*Math.SIN(2*Math.PI/n);

        /// <inheritdoc/>
        public override double Perimeter => 5*a;
        public override string ToString()
        {
            return String.Format("Pentagon, a = {0}", a);
        }
    }
}
