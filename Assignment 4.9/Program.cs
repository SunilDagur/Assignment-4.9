using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._9
{
    using System;

    public enum ShapeType
    {
        Circle,
        Square,
        Triangle
    }

    public class Program
    {
        public static void Main()
        {
            ShapeType shape = ShapeType.Circle; 

            double area = CalculateArea(shape);

            Console.WriteLine($"The area of the {shape} is: {area}");
        }

        public static double CalculateArea(ShapeType shape)
        {
            switch (shape)
            {
                case ShapeType.Circle:
                    double radius = 5.0; 
                    return Math.PI * Math.Pow(radius, 2);

                case ShapeType.Square:
                    double sideLength = 4.0; 
                    return Math.Pow(sideLength, 2);

                case ShapeType.Triangle:
                    double baseLength = 6.0; 
                    double height = 3.0;    
                    return 0.5 * baseLength * height;

                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

}
