using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * This file contains all the definition classes to make sure that the dataGridView displays data nicely.
 * 
 * Its a load of silly boilerplate code but does the job; dataGridViews are hilariuosly easy to use so this is worth it
 * 
 */

namespace ODESolver
{
    /// <summary>
    /// Quick class to populate my bindingList
    /// </summary>
    class PartOneA
    {
        public double StepSize { get; set; }
        public double Euler { get; set; }
        public double ErrorOverStepSize { get; set; }
        public double RK2 { get; set; }
        public double ErrorOverStepSizeSquared { get; set; }
        public double RK4 { get; set; }
        public double ErrorOverActual { get; set; }
        public double Actual { get; set; }


        public PartOneA(double stepSize, double euler, double eulerError, double RK2, double RK2Error, double RK4, double RK4Error, 
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
    class PartOneB
    {
        public double x { get; set; }
        public double EulerPointOne{ get; set; }
        public double EulerPointZeroTwo { get; set;}
        public double EulerPointZeroZeroFive { get; set; }

        public PartOneB(double x, double EulerPointOne, double EulerPointZeroTwo, double EulerPointZeroZeroFive)
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
    class PartTwoB
    {
        public double Time { get; set; }
        public double Current { get; set; }

        public PartTwoB(double time, double current)
        {
            this.Time = time;
            this.Current = current;
        }
    }

    /// <summary>
    /// another Quick class to populate my bindingList
    /// </summary>
    class GeneralCase
    {
        public double StepSize { get; set; }
        public double Euler { get; set; }
        public double RK2 { get; set; }
        public double RK4 { get; set; }

        public GeneralCase(double stepSize, double euler, double RK2, double RK4)
        {
            this.Euler = euler;
            this.RK2 = RK2;
            this.RK4 = RK4;
            this.StepSize = stepSize;
        }
    }

    /// <summary>
    /// quick class for superman
    /// </summary>
    class PartThreeB
    {
        public double Time { get; set; }
        public double Mass { get; set; }

        public PartThreeB(double time, double mass)
        {
            this.Time = time;
            this.Mass = mass;
        }
    }
}
