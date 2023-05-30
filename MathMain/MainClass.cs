using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsMain
{
    public class MathematicsClass
    {
        public static void Main() 
        {
            List<double> list = new List<double>()
            {
                1, 2, 3, 4, 5, 6, 7
            };
            List<double> result = AlgebraClass.SolveSquareRootEquation(-6, 8, -6);
            string resultString = string.Join("  ", result);

            //Вывод алгебры
            Console.WriteLine("Algebra");
            Console.WriteLine("Korni x1,x2: " + resultString);
            Console.WriteLine("Korenb х: " + AlgebraClass.SolveLinearEquation(3, 4));
            Console.WriteLine("Sum row: " + AlgebraClass.SumSeries(list));
            Console.WriteLine("Max row: " + AlgebraClass.MaxSeries(list));
            Console.WriteLine("Avg row: " + AlgebraClass.AvgSeries(list));
            Console.WriteLine(" ");

            //Вывод геометрии
            Console.WriteLine("Geometry");
            Console.WriteLine("S Triang: " + GeometryClass.TriangleArea(10, 4));
            Console.WriteLine("S Right Triangle: " + GeometryClass.RightTriangleArea(10, 4));
            Console.WriteLine("S Rectangl: " + GeometryClass.RectangleArea(10, 6));
            Console.WriteLine("S Circle: " + GeometryClass.CircleArea(10.6));
            Console.WriteLine("S Trapezoid: " + GeometryClass.TrapezoidArea(3, 4, 5));
            Console.WriteLine(" ");

            double a = 4; // Гипотенуза
            double b = 2; // Катет
            double c = 2; // Катет


            //Вывод тригонометрии
            Console.WriteLine("Trigonometry");
            Console.WriteLine("Sin: " + TrigonometryClass.SinValue(a, b, c));
            Console.WriteLine("Cos: " + TrigonometryClass.CosValue(a, b, c));
            Console.WriteLine("Tg: " + TrigonometryClass.TanValue(a, b, c));
            Console.WriteLine("Ctg: " + TrigonometryClass.CotanValue(a, b, c));
            Console.WriteLine("Arcsin: " + TrigonometryClass.ArcsinValue(a, b, c));
        }
    }
}
