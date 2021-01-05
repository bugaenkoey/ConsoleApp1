using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public static class Calculator
    {
 
        public static double Add2(String v1, String v2) => Convert.ToDouble(v1) + Convert.ToDouble(v2);
        public static double Subtract2(String v1, String v2) => Convert.ToDouble(v1) - Convert.ToDouble(v2);
        public static double Multiply2(String v1, String v2) => Convert.ToDouble(v1) * Convert.ToDouble(v2);
        public static double Divide2(String v1, String v2) =>
            (Convert.ToDouble(v2) == 0 ? 0 : Convert.ToDouble(v1)) /
            (Convert.ToDouble(v2) == 0 ? 1 : Convert.ToDouble(v2));

/*
           public static double Add(double v1, double v2) => v1 + v2;
               public static double Subtract(double v1, double v2) => v1 - v2;
               public static double Divide(double v1, double v2) => (v2 == 0 ? 0 : v1) / (v2 == 0 ? 1 : v2);
               public static double Multiply(double v1, double v2) => v1 * v2;
*/

    }
}
