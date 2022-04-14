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
        public Shape getLargestShapeByPerimeter()
        {
            Shape largestShape = null;
            foreach (Shape shape in shapeList)
            {
                if (largestShape == null)
                {
                    largestShape = shape;
                }
                else if(largestShape.Perimeter < shape.Perimeter)
                {
                    largestShape = shape;
                }
            }
            return largestShape;
        }


    }
}