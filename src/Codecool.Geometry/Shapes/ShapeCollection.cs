using System;
using System.Collections.Generic;

namespace Codecool.Geometry.Shapes
{
    public class ShapeCollection
    {
        private List<Shape> shapeList = new List<Shape>();
        public void addShape(Shape shape) 
        {
        shapeList.Add(shape);
        }
        
        
        
        
        /*public string GeometricName { get; }
        public double GeometricArea { get; }
        public double GeoAreaFormula { get; }
        public double GeometricParameter { get; }
        public double GeoParaFormula { get; }
        */
    }

}