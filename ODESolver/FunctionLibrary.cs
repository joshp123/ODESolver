using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODESolver
{
    static class FunctionLibrary
    {
        /// <summary>
        /// Function for Problem 1A
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Evaluates the result of the function -2xy/(1+x^2)</returns>
        public static double Part1A(double x, double y)
        {
            return (-2 * x * y) / (1 + (Math.Pow(x, 2)));
        }

        /// <summary>
        /// Function for Problem 1B, evaluates x^2 + y^2
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Part1B(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2);
        }

        
        /// <summary>
        /// Function for Problem 2B, evaluating the Kirchoff ODE 300
        ///
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Part2B(double x, double y)
        {
            return ((30 * Math.Sin(100 * x)) - ((8.0 * y) / 3.0)) / 0.2;
        }
    }
}
