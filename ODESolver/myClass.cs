using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ODESolver
{
    /// <summary>
    /// Quick class to populate my bindingList
    /// </summary>
    class partOneA
    {
        public double StepSize { get; set; }
        public double Euler { get; set; }
        public double ErrorOverStepSize { get; set; }
        public double RK2 { get; set; }
        public double ErrorOverStepSizeSquared { get; set; }
        public double RK4 { get; set; }
        public double ErrorOverActual { get; set; }
        public double Actual { get; set; }


        public partOneA(double stepSize, double euler, double eulerError, double RK2, double RK2Error, double RK4, double RK4Error, 
            double Actual)
        {
            this.Euler = euler;
            this.ErrorOverStepSize = eulerError;
            this.RK2 = RK2;
            this.ErrorOverStepSizeSquared = RK2Error;
            this.RK4 = RK4;
            this.ErrorOverActual = RK4Error;
            this.Actual = Actual;
            this.StepSize = stepSize;
        }
    }

    /// <summary>
    /// quick class to populate another silly list
    /// </summary>
    class partOneB
    {
        public double x { get; set; }
        public double EulerPointOne{ get; set; }
        public double EulerPointZeroTwo { get; set;}
        public double EulerPointZeroZeroFive { get; set; }

        public partOneB(double x, double EulerPointOne, double EulerPointZeroTwo, double EulerPointZeroZeroFive)
        {
            this.x = x;
            this.EulerPointOne = EulerPointOne;
            this.EulerPointZeroTwo = EulerPointZeroTwo;
            this.EulerPointZeroZeroFive = EulerPointZeroZeroFive;
        }
    }

    /// <summary>
    /// quick class for prob 2
    /// </summary>
    class problem2Class
    {
        public double butts;
    }

    /// <summary>
    /// another Quick class to populate my bindingList
    /// </summary>
    class generalCase
    {
        public double StepSize { get; set; }
        public double Euler { get; set; }
        public double RK2 { get; set; }
        public double RK4 { get; set; }

        public generalCase(double stepSize, double euler, double RK2, double RK4)
        {
            this.Euler = euler;
            this.RK2 = RK2;
            this.RK4 = RK4;
            this.StepSize = stepSize;
        }
    }
}
