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
            Shape largestShapeByPerimeter = null;
            foreach (Shape shape in shapeList)
            {
                if (largestShapeByPerimeter == null)
                {
                    largestShapeByPerimeter = shape;
                }
                else if(largestShapeByPerimeter.Perimeter < shape.Perimeter)
                {
                    largestShapeByPerimeter = shape;
                }
            }
            return largestShapeByPerimeter;
        }
        public Shape getLargestShapeByArea()
        {
            Shape largestShapeByArea = null;
            foreach (Shape shape in shapeList)
            {
                if (largestShapeByArea == null)
                {
                    largestShapeByArea = shape;
                }
                else if (largestShapeByArea.Area < shape.Area)
                {
                    largestShapeByArea = shape;
                }

            }
            return largestShapeByArea;
        }


    }
}