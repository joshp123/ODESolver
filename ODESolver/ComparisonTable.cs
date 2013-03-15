using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ODESolver
{
    /// <summary>
    /// Class w/event handling methods for all the controls on the form.
    /// </summary>
    public partial class ComparisonTable : UserControl
    {
        public ComparisonTable()
        {
            InitializeComponent();
        }

        Tweeter tweetMachine = new Tweeter();

        private void sizePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evaluates the user-specified equation at a certain value of x,y using mathematica
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Returns the value of the equation at a certain point in time</returns>
        /// <remarks>Reads the equation in from the text field and replaces all the xs with a number, so make sure you
        /// enter it formatted correctly (i.e. xy won't work. use x * y )</remarks>
        private double userEquationMathematica(double x, double y)
        {
            var equation = userEquation.Text.Replace("x", Convert.ToString(x));
            equation = equation.Replace("y", Convert.ToString(y));
            return FunctionLibrary.Mathematica(equation);
        }

        /// <summary>
        /// Calculates the result of ANY ODE. mathematica does the hard bit of parsing the equation as a string and
        /// evaluating it, so mathematica has to be installed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculate_Click(object sender, EventArgs e)
        {

            var lowerBound = Convert.ToDouble(lowerBoundPicker.Value);
            var upperBound = Convert.ToDouble(upperBoundPicker.Value);
            var dependentInitial = Convert.ToDouble(initialConditionPicker.Value);

            var equation = userEquation.Text;

            // equation string to delegate function
            Program.ODEFunction function = userEquationMathematica;

            try
            {
                function(3, 5);
                // try calling a function using the mathematica API. if this fails we know shit is broken
                // ran out of time to test this so it will probably break hialriously.

            }
            catch (Exception)
            {
                MessageBox.Show("Mathematica linking failed. Please ensure mathematica is installed.");
                return;
            }

            BindingList<GeneralCase> calculations = new BindingList<GeneralCase>();

            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            if (loopRadio.Checked == true)
            {
                var loopStringsArray = loopValuesPicker.Text.Split(new string[] { ", " }, StringSplitOptions.None);

                var loopValuesArray = loopStringsArray.Select(s => Convert.ToDouble(s)).ToArray();

                foreach (var stepSize in loopValuesArray)
                {
                    // add item to params 

                    var euler = Program.Euler(function, stepSize, lowerBound, upperBound, dependentInitial);

                    var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);

                    var rK4 = Program.RKOrder4(function, stepSize, lowerBound, upperBound, dependentInitial);

                    calculations.Add(new GeneralCase(stepSize, euler, rK2, rK4));

                }
            }

            else
            {
                var stepSize = Convert.ToDouble(sizePicker.Value);

                var euler = Program.Euler(function, stepSize, lowerBound, upperBound, dependentInitial);

                var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);

                var rK4 = Program.RKOrder4(function, stepSize, lowerBound, upperBound, dependentInitial);

                calculations.Add(new GeneralCase(stepSize, euler, rK2, rK4));
            }
            
            dataGridView1.Refresh();

            // populate the datagridview
            // - write codebehind for looping over different H values
            // - textbox with comma separated H values 0.1, 0.01, 0.05 etc
            //- add ODE box for eqn 
            //- codebehind for parsing string (replace "x" with var)

            //- add buttons for presets (maybe generate the bindinglists?)

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // its nice that they generate method stubs when you double click stuff but not that they hang around in 
            // your source
        }

        private void sizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void task1_Click(object sender, EventArgs e)
        {
            Program.ODEFunction function = FunctionLibrary.Part1A;
            // set up function

            userEquation.Text = "(-2 * x * y)/( 1 + x^2)";
            // use this as example of how the user-input works

            // initialize params
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

            // initialize list to store results
            BindingList<PartOneA> calculations = new BindingList<PartOneA>();

            // set datagrid view to results list
            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            foreach (var stepSize in loopValues)
            {
                // evaluate euler/rk2/4 for each step size; add them to the list

                var euler = Program.Euler(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverStepSize = Math.Abs(euler - actualSolution) / stepSize;

                var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverStepSizeSquared =  Math.Abs(rK2 - actualSolution) / Math.Pow(stepSize, 2);

                var rK4 = Program.RKOrder4(function, stepSize, lowerBound, upperBound, dependentInitial);
                var errorOverActual = Math.Abs(rK4 - actualSolution) / actualSolution;

                calculations.Add(new PartOneA(stepSize, euler, errorOverStepSize, rK2, errorOverStepSizeSquared, rK4,
                    errorOverActual, actualSolution));

            }

            dataGridView1.Refresh();
 
            // populate the datagridview
        }

        private void task2b_Click(object sender, EventArgs e)
        {
            userEquation.Text = "((30 * sin(100 * x)) - ((8.0 * y) / 3.0))) / 0.2";
            // use this as example of how the user-input works
            
            
            // initialize our values used
            double lowerBound = 0.0;
            double upperBound = 0.4;
            double dependentInitial = 0;

            double stepSize = 0.005;

            // populate the pickers with the data for this run

            lowerBoundPicker.Value = Convert.ToDecimal(lowerBound);
            upperBoundPicker.Value = Convert.ToDecimal(upperBound);
            initialConditionPicker.Value = Convert.ToDecimal(dependentInitial);
            sizePicker.Value = Convert.ToDecimal(stepSize);

            Program.ODEFunction function = FunctionLibrary.Part2B;
            // assign the delegate function for this equation

            // evaluate the first current required
            var rK2 = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);
            MessageBox.Show("The value of i2 at t = 0.4s is:\n" + rK2.ToString() +
                "\n\nThe value of i1 at t = 0.4s is:\n " + "butts" + "\n\nNow generating table for plot against time and displaying the graph.");

            BindingList<PartTwoB> calculations = new BindingList<PartTwoB>();
            // initialize list

            dataGridView1.DataSource = calculations;
            // bind to the datagrid view

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            for (decimal time = 0.0m; time <= 0.4m; time+= 0.005m)
            {
                // 420 loop over decimals b/c its easier that way
                // don't loop over less than stepSize otherwise nothing will change!

                upperBound = Convert.ToDouble(time);
                // make it a double to keep the RK function happy

                var current  = Program.RKOrder2(function, stepSize, lowerBound, upperBound, dependentInitial);

                calculations.Add(new PartTwoB(upperBound, current));
                // add this result to our list
            }

            dataGridView1.Refresh();

            // now display the graph
            
            // this using block borrowed (and modified) from a useful stack overflow post
            using (Form form = new Form())
            {
                Bitmap img = ODESolver.Properties.Resources.task2;

                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = img.Size;
                form.Height += 30;
                form.Width += 30;
                
                // account for window padding
                
                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.Image = img;

                form.Controls.Add(picture);
                form.ShowDialog();
            }

        }

        private void task1B_Click(object sender, EventArgs e)
        {
            Program.ODEFunction function = FunctionLibrary.Part1B;
            // assign delegate function

            userEquation.Text = "(x^2) + (y^2)";
            // use this as example of how the user-input works

            // initialize params
            double[] loopValues = new double[] { 0.04, 0.02, 0.01, 0.005, 0.0025, 0.00125 };

            double lowerBound = 0.0;
            double upperBound = 1.0;
            double dependentInitial = 1.0;

            BindingList<PartOneB> calculations = new BindingList<PartOneB>();
            // initialize list and bind to datagrid
            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            for (int tenX = 0; tenX <= 10; tenX++)
            {
                // loop over all the x values
                upperBound = tenX / 10.0;
                
                var EulerPointOne = Program.Euler(function, 0.1, lowerBound, upperBound, dependentInitial);
                var EulerPointZeroTwo = Program.Euler(function, 0.02, lowerBound, upperBound, dependentInitial);
                var EulerPointZeroZeroFive = Program.Euler(function, 0.005, lowerBound, upperBound, dependentInitial);

                calculations.Add(new PartOneB(upperBound, EulerPointOne, EulerPointZeroTwo, EulerPointZeroZeroFive));
                // add these entries to the list
            }

            dataGridView1.Refresh();
            // populate the datagridview


        }

        private void tweetButton_Click(object sender, EventArgs e)
        {
            // do screenshot using an external library
            ScreenShotDemo.ScreenCapture pic = new ScreenShotDemo.ScreenCapture();

            Image img = pic.CaptureWindow(this.Handle);
            // cap this window

            string input = Microsoft.VisualBasic.Interaction.InputBox("Accompany your results tweet with a <100char message?", "Tweet", "Having a great time solvin ODEs with my pal @ODEBot9000", 0, 0);

            img.Save("temp.bmp");

            var response = tweetMachine.TweetImage("temp.bmp", input);

            string regex = "<url>(.*?)</url>";

            Match match = Regex.Match(response.Content, regex);
            var url = match.Value.Substring(5, match.Value.Length - 11);
            tweetMachine.SendTweet(input + "  " + url);
            
            // tweet input + SS
        }

        private void calculateTask3_Click(object sender, EventArgs e)
        {
            userEquation.Text = "(y * log(0.5)) / 15";
            // use this as example of how the user-input works

            double lowerBound = 0.0;
            double upperBound = 100;
            double dependentInitial = 1;

            double stepSize = 0.005;

            // populate the pickers with the data for this run

            lowerBoundPicker.Value = Convert.ToDecimal(lowerBound);
            upperBoundPicker.Value = Convert.ToDecimal(upperBound);
            initialConditionPicker.Value = Convert.ToDecimal(dependentInitial);
            sizePicker.Value = Convert.ToDecimal(stepSize);


            Program.ODEFunction function = FunctionLibrary.Part3B;

            BindingList<PartThreeB> calculations = new BindingList<PartThreeB>();

            dataGridView1.DataSource = calculations;

            // if i had time i would add a load of boilerplate code to make the columns have nice headers and stuff
            // but :effort:

            for (int time = 0; time <= 100; time++)
            {
                // 420 loop over decimals b/c its easier that way
                // don't loop over less than stepSize otherwise nothing will change!

                upperBound = Convert.ToDouble(time);
                // make it a double to keep the RK function happy

                var mass = Program.RKOrder4(function, stepSize, lowerBound, upperBound, dependentInitial);

                calculations.Add(new PartThreeB(upperBound, mass));
                // add this result to our list
            }

            dataGridView1.Refresh();

            // now display the graph
            MessageBox.Show("As you will see on the following graph, Superman is safe after 50 hours.");

            // this using block borrowed (and modified) from a useful stack overflow post
            using (Form form = new Form())
            {
                Bitmap img = ODESolver.Properties.Resources.task3;

                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = img.Size;
                form.Height += 30;
                form.Width += 30;

                // account for window padding

                PictureBox picture = new PictureBox();
                picture.Dock = DockStyle.Fill;
                picture.Image = img;

                form.Controls.Add(picture);
                form.ShowDialog();
            }
        }
    }
}
