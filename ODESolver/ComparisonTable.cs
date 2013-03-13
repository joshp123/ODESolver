using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODESolver
{
    public partial class ComparisonTable : UserControl
    {
        public ComparisonTable()
        {
            InitializeComponent();
        }

        private void sizePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var stepSize = Convert.ToDouble(sizePicker.Value);
            var lowerBound = Convert.ToDouble(lowerBoundPicker.Value);
            var upperBound = Convert.ToDouble(upperBoundPicker.Value);
            var dependentInitial = Convert.ToDouble(initialConditionPicker.Value);

            var equation = userEquation.Text;

            // equation string to delegate function ???


            // - write codebehind for looping over different H values
            // - textbox with comma separated H values 0.1, 0.01, 0.05 etc
            //- add ODE box for eqn 
            //- codebehind for parsing string (replace "x" with var)

            //- add buttons for presets (maybe generate the bindinglists?)

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {
            Program.ODEFunction function = FunctionLibrary.Part1A;

            double[] loopValues= new double[] { 0.04, 0.02, 0.01, 0.005, 0.0025, 0.00125 };

            double lowerBound = 0.0;
            double upperBound = 1.0;
            double dependentInitial = 1.0;
            double actualSolution = 0.5;

            // udpate controls so user can see values used

            lowerBoundPicker.Value = Convert.ToDecimal(lowerBound);
            upperBoundPicker.Value = Convert.ToDecimal(upperBound);
            initialConditionPicker.Value = Convert.ToDecimal(dependentInitial);
            sizePicker.Value = Convert.ToDecimal(loopValues[0]);

            BindingList<partOneA> calculations = new BindingList<partOneA>();

            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            foreach (var stepSize in loopValues)
            {
                // add item to params 

                var euler = Program.Euler(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverStepSize = Math.Abs(euler - actualSolution) / stepSize;

                var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverStepSizeSquared =  Math.Abs(rK2 - actualSolution) / Math.Pow(stepSize, 2);

                var rK4 = Program.RKOrder4(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverActual = Math.Abs(rK4 - actualSolution) / actualSolution;

                calculations.Add(new partOneA(stepSize, euler, errorOverStepSize, rK2, errorOverStepSizeSquared, rK4,
                    errorOverActual, actualSolution));


            }

            dataGridView1.Refresh();
 
            // populate the datagridview
        }

        private void task2b_Click(object sender, EventArgs e)
        {
            double lowerBound = 0.0;
            double upperBound = 0.4;
            double dependentInitial = 0;

            double stepSize = 0.005;
            
            lowerBoundPicker.Value = Convert.ToDecimal(lowerBound);
            upperBoundPicker.Value = Convert.ToDecimal(upperBound);
            initialConditionPicker.Value = Convert.ToDecimal(dependentInitial);
            sizePicker.Value = Convert.ToDecimal(stepSize);

            Program.ODEFunction function = FunctionLibrary.Part2B;

            var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);

            MessageBox.Show(rK2.ToString());

        }

        private void task1B_Click(object sender, EventArgs e)
        {
            Program.ODEFunction function = FunctionLibrary.Part1B;

            double[] loopValues = new double[] { 0.04, 0.02, 0.01, 0.005, 0.0025, 0.00125 };

            double lowerBound = 0.0;
            double upperBound = 1.0;
            double dependentInitial = 1.0;

            BindingList<partOneB> calculations = new BindingList<partOneB>();

            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            for (int tenX = 0; tenX < 10; tenX++)
            {
                upperBound = tenX / 10.0;

                var EulerPointOne = Program.Euler(function, 0.1, lowerBound, upperBound, dependentInitial);
                var EulerPointZeroTwo = Program.Euler(function, 0.02, lowerBound, upperBound, dependentInitial);
                var EulerPointZeroZeroFive = Program.Euler(function, 0.005, lowerBound, upperBound, dependentInitial);

                calculations.Add(new partOneB(upperBound, EulerPointOne, EulerPointZeroTwo, EulerPointZeroZeroFive));
            }

            dataGridView1.Refresh();

            // populate the datagridview
        }
    }
}
