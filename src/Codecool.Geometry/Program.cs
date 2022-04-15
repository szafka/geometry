﻿using Codecool.Geometry.Shapes;
using System;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        static ShapeCollection shapeCollection = new ShapeCollection();
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
           /*
            Triangle triangle = new Triangle(3.0, 3.0, 3.0);
            Square square = new Square(4.0);
            Rectangle rectangle = new Rectangle(4.0, 120.0);

            shapeCollection.addShape(triangle);
            shapeCollection.addShape(square);
            shapeCollection.addShape(rectangle);
            */
            
           

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Choose number:");
                Console.WriteLine("1 : Add new shape");
                Console.WriteLine("2 : Show all shapes");
                Console.WriteLine("3 : Show shpe with the largest perimeter");
                Console.WriteLine("4 : Show shpe with the largest Area");
                Console.WriteLine("5 : Show formulas");
                Console.WriteLine("0 : Exit");
                Console.WriteLine(" ");
                int option = Convert.ToInt32(Console.ReadLine());
                // TODO read the keyboard here

                switch (option)
                {
                    case 1:
                        addShape();
                        // TODO Add new shape
                        break;
                    case 2:
                        // TODO Show all shapes
                        Console.WriteLine(shapeCollection.getShapesTable());
                        break;
                    case 3:
                        Shape newShape1 = shapeCollection.getLargestShapeByPerimeter();
                        Console.WriteLine(newShape1);
                        break;
                    case 4:
                        Console.WriteLine(shapeCollection.getLargestShapeByArea());
                        // TODO Show shape with the largest area
                        break;
                    case 5:
                        showFormulas();
                        // TODO Show formulas
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }
            }
        }
        private static int chooseShape()
        {
            Console.WriteLine("Choose shape:");
            Console.WriteLine("1 : Circle");
            Console.WriteLine("2 : Triangle");
            Console.WriteLine("3 : EquilateralTriangle");
            Console.WriteLine("4 : Regular Pentagon");
            Console.WriteLine("5 : Square");
            Console.WriteLine("6 : Rectangle");
            Console.WriteLine("0 : Return");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        private static void showFormulas()
        {
            switch(chooseShape())
            {
                case 1:
                    Console.WriteLine(String.Format("Circle area formula: {0}, Circle perimeter formula: {1}",Circle.AreaFormula,Circle.PerimeterFormula));
                    break;
            }
        }
        private static void addShape()
        {
            switch (chooseShape())
            {
                case 1:
                    shapeCollection.addShape(createCircle());
                    break;
            }
        }
        private static Circle createCircle()
        {
            Console.WriteLine("Podaj długość promienia r:");
            double r = Double.Parse(Console.ReadLine());
            return new Circle(r);
        }

    }
}
