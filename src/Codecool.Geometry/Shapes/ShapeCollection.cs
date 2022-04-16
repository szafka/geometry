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
        public String getShapesTable()
        
        {


            String table = "/-------------------------------------------------------------------------------------------------------------------------------------------\\\n" +
                           "| ID |                Class |                                toString |  Perimeter |   Formula |       Area |                       Formula |\n";
                           

            int i = 0;
            foreach (Shape shape in shapeList)
            {
                table += "| ---| ---------------------| ----------------------------------------| -----------| ----------| -----------| ------------------------------| \n";
                table = table + String.Format("|{0,4}|{1,22}|{2,41}|{3,12:#.000}|{4,11}|{5,12:#.000}|{6,31}|\n",
                    i++,
                    shape.GetType().Name,
                    shape.ToString(),
                    shape.Perimeter,
                    shape.GetType().GetProperty("PerimeterFormula").GetValue(null,null),
                    shape.Area,
                    shape.GetType().GetProperty("AreaFormula").GetValue(null, null));
            }
            table += "\\ ---| ---------------------| ----------------------------------------| -----------| ----------| -----------| ------------------------------/ \n";
            return table;
        }


    }
}