using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class GeometryClass
    {
        //Задание геометрия: площадь треугольника, прямоугольного треугольника, прямоугольника, круга, трапеции

        //площадь треугольника
        public static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        //площадь прямоугольного треугольника
        public static double RightTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        //площаль прямоугольника
        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        //площадь круга
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        //площадь трапеции
        public static double TrapezoidArea(double base1, double base2, double height)
        {
            return 0.5 * (base1 + base2) * height;
        }
    }
}

