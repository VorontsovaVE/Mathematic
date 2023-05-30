using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class TrigonometryClass
    {
        //Задание тригонометрия: синус, косинус, тангенс, котангенс, арксинус


        //Синус
        public static double SinValue(double a, double b, double c)
        {
            return b / a;
        }

        //Косинус
        public static double CosValue(double a, double b, double c)
        {
            return c / a;
        }

        //Тангенс
        public static double TanValue(double a, double b, double c)
        {
            return b / c;
        }

        //Катангенс
        public static double CotanValue(double a, double b, double c)
        {
            return c / b;
        }

        //Арксинус
        public static double ArcsinValue(double a, double b, double c)
        {
            return Math.Asin(SinValue(a, b, c));
        }
    }
}
