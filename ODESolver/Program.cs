using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TweetSharp;

namespace ODESolver
{
    static class Program
    {
        /// <summary>
        /// Type of function that can be used for evaluating an ODE. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <remarks>Essentially all this does is restrict the type of functions that can be passed to our Euler and RK
        /// methods so that they conform with what the Euler and RK methods specify; i.e. only 2 variables, and
        /// returning only a single double value.
        /// 
        /// This has a few advantages:
        /// 
        /// - The Euler/RK method are generalised, minimizing the size of the code base, and simplifying calling
        ///   them in code. Without using delegates, the Euler/RK method would have to be rewritten and recompiled for
        ///   every separate function you want to evaluate, which is dumb as hell really
        ///   
        /// - We can have a small class storing a library of functions for the ODEs we wish to evaluate keeping them in
        ///   one easily maintainable place
        ///   
        /// - It would be relatively simple to extend this to allow a user to input any 2-variable function, and using
        ///   an external API (e.g. Mathematica), evaluate the function using only minimal wrapper code, and solve it
        ///   using Euler/RK methods. (i will probably do this when i get bored)
        ///</remarks>
        public delegate double ODEFunction(double x, double y);
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Tweeter tweetMachine = new Tweeter();
            // initialize and configure the tweeter

            //var myString = "Hey, I just met you / And this is lazy / But here's my homework / Solve me maybe";
            //var result = tweetMachine.SendTweet(myString);
            //MessageBox.Show("Euler: " + butts.ToString() + "\n" + "RK2: " + butts1.ToString() + "\nRK4: " + butts2.ToString());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Method to evaluate the "Euler method" for any given function.
        /// </summary>
        /// <param name="function">the function to </param>
        /// <param name="stepSize"></param>
        /// <param name="lowerBound">Lower bound of range to evaluate over</param>
        /// <param name="upperBound">Upper bound of range to evaluate over</param>
        /// <param name="dependentInitial">Initial dependent value, e.g. y(lowerBound) = ____</param>
        /// <returns></returns>
        public static double Euler(ODEFunction Function, double stepSize, double lowerBound, double upperBound, double dependentInitial)
        {
            // using convention defining "y" as dependent variable and "x" as independent variable

            // i may have screwed the termoinology up b/c differential eqns are hard

            var totalSteps = (upperBound - lowerBound) / stepSize;

            double dependentFinal = 0.0;
            // declare as blank to keep compiler happy

            double independent = lowerBound;

            for (int i = 0; i < totalSteps; i++)
            {
                dependentFinal = dependentInitial + (stepSize * (Function(independent, dependentInitial)));

                independent += stepSize;

                dependentInitial = dependentFinal;
            }

            // FUN FACT: if you implement the algo as written in the example it breaks for small step sizes 
            // beacuse you're using a double-precision float for flow of control. when the step size is super small
            // and then added to "independent", floating point errors are introduced, which means when you get to the final
            // iteration that doesn't actually occur becuse if upper bound is 1.0 independent is like 1.00000000000012 
            // due to floating point errors.

            //while (independent <= upperBound)
            //{
            //    dependentFinal = dependentInitial + (stepSize * (Function(independent, dependentInitial)));

            //    independent += stepSize;

            //    dependentInitial = dependentFinal;

            //}

            return dependentFinal;
        }

        public static double RKOrder2(ODEFunction Function, double stepSize, double lowerBound, double upperBound, double dependentInitial)
        {
            double dependentFinal = 0.0;
            // declare as blank to keep compiler happy

            double KIncrement1, KIncrement2, u;
            // using KIncrementN for k1-k4 increments, u staying as u despite not being very human readable oh well
           
            double independent = lowerBound;

            var totalSteps = (upperBound - lowerBound) / stepSize;

            for (int i = 0; i < totalSteps; i++)
            {
                // calculating intermediary values
                KIncrement1 = Function(independent, dependentInitial);

                u = dependentInitial + (stepSize * KIncrement1);

                KIncrement2 = Function(independent + stepSize, u);

                // calculating value
                dependentFinal = dependentInitial + (stepSize * 0.5 * (KIncrement1 + KIncrement2));

                // iterating
                independent += stepSize;
                dependentInitial = dependentFinal;
            }
            
            return dependentFinal;
        }

        public static double RKOrder4(ODEFunction Function, double stepSize, double lowerBound, double upperBound, double dependentInitial)
        {
            double dependentFinal = 0.0;
            // declare as blank to keep compiler happy

            double KIncrement1, KIncrement2, KIncrement3, KIncrement4;
            // using KIncrementN for k1-k4 increments, u staying as u despite not being very human readable oh well

            double independent = lowerBound;

            var totalSteps = (upperBound - lowerBound) / stepSize;

            for (int i = 0; i < totalSteps; i++)
            {
                // Calculating k increments
                
                KIncrement1 = stepSize * Function(independent, dependentInitial);

                KIncrement2 = stepSize * (Function(independent + (0.5 * stepSize), dependentInitial +
                    (0.5 * KIncrement1)));

                KIncrement3 = stepSize * (Function(independent + (0.5 * stepSize), dependentInitial +
                    (0.5 * KIncrement2)));

                KIncrement4 = stepSize * (Function(independent + stepSize, dependentInitial + KIncrement3));

                // summing k increments

                dependentFinal = dependentInitial + ((1.0/6.0) * (KIncrement1 + (2 * (KIncrement2 +
                    KIncrement3)) + KIncrement4));

                // iterating
                independent += stepSize;
                dependentInitial = dependentFinal;
            }

            return dependentFinal;
        }
    }
}
