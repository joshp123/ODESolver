namespace ODESolver
{
    partial class ComparisonTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComponentTitle = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.lowerBoundLabel = new System.Windows.Forms.Label();
            this.lowerBoundPicker = new System.Windows.Forms.NumericUpDown();
            this.upperBoundLabel = new System.Windows.Forms.Label();
            this.upperBoundPicker = new System.Windows.Forms.NumericUpDown();
            this.initialConditionLabel = new System.Windows.Forms.Label();
            this.initialConditionPicker = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tweetButton = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizePicker = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eqnLabel = new System.Windows.Forms.Label();
            this.userEquation = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.task2b = new System.Windows.Forms.Button();
            this.calculateTask3 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.task1 = new System.Windows.Forms.Button();
            this.task1B = new System.Windows.Forms.Button();
            this.loopValuesPicker = new System.Windows.Forms.TextBox();
            this.loopRadio = new System.Windows.Forms.RadioButton();
            this.singleStepRadio = new System.Windows.Forms.RadioButton();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialConditionPicker)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePicker)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComponentTitle
            // 
            this.ComponentTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ComponentTitle, 2);
            this.ComponentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComponentTitle.Location = new System.Drawing.Point(13, 10);
            this.ComponentTitle.Name = "ComponentTitle";
            this.ComponentTitle.Size = new System.Drawing.Size(658, 41);
            this.ComponentTitle.TabIndex = 1;
            this.ComponentTitle.Text = "Program to calculate the results of any given ODE using Euler, RK2, and RK4 metho" +
    "ds.\r\nUse the buttons below to display the specific results for the assigned ques" +
    "tions.\r\n";
            this.ComponentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(40, 190);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(77, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Step Size, \"h\":";
            this.sizeLabel.Click += new System.EventHandler(this.sizeLabel_Click);
            // 
            // lowerBoundLabel
            // 
            this.lowerBoundLabel.AutoSize = true;
            this.lowerBoundLabel.Location = new System.Drawing.Point(40, 278);
            this.lowerBoundLabel.Name = "lowerBoundLabel";
            this.lowerBoundLabel.Size = new System.Drawing.Size(136, 13);
            this.lowerBoundLabel.TabIndex = 5;
            this.lowerBoundLabel.Text = "Independent Lower Bound:";
            // 
            // lowerBoundPicker
            // 
            this.lowerBoundPicker.DecimalPlaces = 5;
            this.lowerBoundPicker.Location = new System.Drawing.Point(43, 294);
            this.lowerBoundPicker.Name = "lowerBoundPicker";
            this.lowerBoundPicker.Size = new System.Drawing.Size(120, 20);
            this.lowerBoundPicker.TabIndex = 4;
            // 
            // upperBoundLabel
            // 
            this.upperBoundLabel.AutoSize = true;
            this.upperBoundLabel.Location = new System.Drawing.Point(40, 370);
            this.upperBoundLabel.Name = "upperBoundLabel";
            this.upperBoundLabel.Size = new System.Drawing.Size(133, 13);
            this.upperBoundLabel.TabIndex = 7;
            this.upperBoundLabel.Text = "Independent Upper Bound";
            // 
            // upperBoundPicker
            // 
            this.upperBoundPicker.DecimalPlaces = 5;
            this.upperBoundPicker.Location = new System.Drawing.Point(43, 386);
            this.upperBoundPicker.Name = "upperBoundPicker";
            this.upperBoundPicker.Size = new System.Drawing.Size(120, 20);
            this.upperBoundPicker.TabIndex = 6;
            // 
            // initialConditionLabel
            // 
            this.initialConditionLabel.AutoSize = true;
            this.initialConditionLabel.Location = new System.Drawing.Point(40, 472);
            this.initialConditionLabel.Name = "initialConditionLabel";
            this.initialConditionLabel.Size = new System.Drawing.Size(142, 26);
            this.initialConditionLabel.TabIndex = 9;
            this.initialConditionLabel.Text = "Initial Condition:\r\ne.g. y(0) = y(lowerBound) = 1";
            // 
            // initialConditionPicker
            // 
            this.initialConditionPicker.DecimalPlaces = 5;
            this.initialConditionPicker.Location = new System.Drawing.Point(43, 501);
            this.initialConditionPicker.Name = "initialConditionPicker";
            this.initialConditionPicker.Size = new System.Drawing.Size(120, 20);
            this.initialConditionPicker.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.28121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.82232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.93539F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.ComponentTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.92173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.72261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.61072F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.19053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.78579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.78579F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(899, 796);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tweetButton);
            this.panel2.Controls.Add(this.calculate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(681, 714);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 69);
            this.panel2.TabIndex = 12;
            // 
            // tweetButton
            // 
            this.tweetButton.Location = new System.Drawing.Point(0, 43);
            this.tweetButton.Name = "tweetButton";
            this.tweetButton.Size = new System.Drawing.Size(202, 23);
            this.tweetButton.TabIndex = 10;
            this.tweetButton.Text = "Tweet this result @ODEBot9000!";
            this.tweetButton.UseVisualStyleBackColor = true;
            this.tweetButton.Click += new System.EventHandler(this.tweetButton_Click);
            // 
            // calculate
            // 
            this.calculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculate.Location = new System.Drawing.Point(67, 9);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate!";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.Size = new System.Drawing.Size(662, 579);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stepsLabel);
            this.panel1.Controls.Add(this.singleStepRadio);
            this.panel1.Controls.Add(this.loopRadio);
            this.panel1.Controls.Add(this.loopValuesPicker);
            this.panel1.Controls.Add(this.lowerBoundLabel);
            this.panel1.Controls.Add(this.lowerBoundPicker);
            this.panel1.Controls.Add(this.sizeLabel);
            this.panel1.Controls.Add(this.upperBoundLabel);
            this.panel1.Controls.Add(this.upperBoundPicker);
            this.panel1.Controls.Add(this.sizePicker);
            this.panel1.Controls.Add(this.initialConditionPicker);
            this.panel1.Controls.Add(this.initialConditionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(681, 129);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 4);
            this.panel1.Size = new System.Drawing.Size(205, 579);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sizePicker
            // 
            this.sizePicker.DecimalPlaces = 5;
            this.sizePicker.Location = new System.Drawing.Point(43, 206);
            this.sizePicker.Name = "sizePicker";
            this.sizePicker.Size = new System.Drawing.Size(120, 20);
            this.sizePicker.TabIndex = 2;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.eqnLabel);
            this.panel5.Controls.Add(this.userEquation);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(13, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(662, 69);
            this.panel5.TabIndex = 9;
            // 
            // eqnLabel
            // 
            this.eqnLabel.AutoSize = true;
            this.eqnLabel.Location = new System.Drawing.Point(136, 17);
            this.eqnLabel.Name = "eqnLabel";
            this.eqnLabel.Size = new System.Drawing.Size(380, 26);
            this.eqnLabel.TabIndex = 1;
            this.eqnLabel.Text = "Enter any ODE here in the form that can be parsed by the Mathematica engine:\r\nUse" +
    " only \"x\" and \"y\" variables.";
            // 
            // userEquation
            // 
            this.userEquation.Location = new System.Drawing.Point(188, 46);
            this.userEquation.Name = "userEquation";
            this.userEquation.Size = new System.Drawing.Size(328, 20);
            this.userEquation.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(323, 714);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.task2b);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calculateTask3);
            this.splitContainer1.Size = new System.Drawing.Size(352, 69);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 10;
            // 
            // task2b
            // 
            this.task2b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task2b.AutoSize = true;
            this.task2b.Location = new System.Drawing.Point(78, 5);
            this.task2b.Name = "task2b";
            this.task2b.Size = new System.Drawing.Size(186, 23);
            this.task2b.TabIndex = 0;
            this.task2b.Text = "Calculate Task 2B (Kirchoff)";
            this.task2b.UseVisualStyleBackColor = true;
            this.task2b.Click += new System.EventHandler(this.task2b_Click);
            // 
            // calculateTask3
            // 
            this.calculateTask3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculateTask3.Location = new System.Drawing.Point(78, 6);
            this.calculateTask3.Name = "calculateTask3";
            this.calculateTask3.Size = new System.Drawing.Size(185, 23);
            this.calculateTask3.TabIndex = 0;
            this.calculateTask3.Text = "Calculate Task 3 and show graph";
            this.calculateTask3.UseVisualStyleBackColor = true;
            this.calculateTask3.Click += new System.EventHandler(this.calculateTask3_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(13, 714);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.task1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.task1B);
            this.splitContainer2.Size = new System.Drawing.Size(304, 69);
            this.splitContainer2.SplitterDistance = 33;
            this.splitContainer2.TabIndex = 13;
            // 
            // task1
            // 
            this.task1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task1.Location = new System.Drawing.Point(46, 5);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(212, 23);
            this.task1.TabIndex = 7;
            this.task1.Text = "Calculate Task 1,2,3A (comparing errors)\r\n";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task1B
            // 
            this.task1B.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.task1B.Location = new System.Drawing.Point(46, 6);
            this.task1B.Name = "task1B";
            this.task1B.Size = new System.Drawing.Size(212, 23);
            this.task1B.TabIndex = 0;
            this.task1B.Text = "Calculate Task 1B (more Euler)";
            this.task1B.UseVisualStyleBackColor = true;
            this.task1B.Click += new System.EventHandler(this.task1B_Click);
            // 
            // loopValuesPicker
            // 
            this.loopValuesPicker.Location = new System.Drawing.Point(42, 121);
            this.loopValuesPicker.Multiline = true;
            this.loopValuesPicker.Name = "loopValuesPicker";
            this.loopValuesPicker.Size = new System.Drawing.Size(140, 37);
            this.loopValuesPicker.TabIndex = 10;
            this.loopValuesPicker.Text = "0.04, 0.02, 0.01, 0.005, 0.0025, 0.00125";
            // 
            // loopRadio
            // 
            this.loopRadio.AutoSize = true;
            this.loopRadio.Checked = true;
            this.loopRadio.Location = new System.Drawing.Point(43, 22);
            this.loopRadio.Name = "loopRadio";
            this.loopRadio.Size = new System.Drawing.Size(123, 17);
            this.loopRadio.TabIndex = 11;
            this.loopRadio.TabStop = true;
            this.loopRadio.Text = "Loop Over Step Size";
            this.loopRadio.UseVisualStyleBackColor = true;
            // 
            // singleStepRadio
            // 
            this.singleStepRadio.AutoSize = true;
            this.singleStepRadio.Location = new System.Drawing.Point(43, 46);
            this.singleStepRadio.Name = "singleStepRadio";
            this.singleStepRadio.Size = new System.Drawing.Size(102, 17);
            this.singleStepRadio.TabIndex = 12;
            this.singleStepRadio.Text = "Single Step Size";
            this.singleStepRadio.UseVisualStyleBackColor = true;
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Location = new System.Drawing.Point(40, 92);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(116, 26);
            this.stepsLabel.TabIndex = 13;
            this.stepsLabel.Text = "Step Sizes to evaluate.\r\nSeparate by \", \"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "dy/dx = ";
            // 
            // ComparisonTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComparisonTable";
            this.Size = new System.Drawing.Size(899, 796);
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialConditionPicker)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePicker)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ComponentTitle;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label lowerBoundLabel;
        private System.Windows.Forms.NumericUpDown lowerBoundPicker;
        private System.Windows.Forms.Label upperBoundLabel;
        private System.Windows.Forms.NumericUpDown upperBoundPicker;
        private System.Windows.Forms.Label initialConditionLabel;
        private System.Windows.Forms.NumericUpDown initialConditionPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown sizePicker;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox userEquation;
        private System.Windows.Forms.Label eqnLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button task2b;
        private System.Windows.Forms.Button calculateTask3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tweetButton;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task1B;
        private System.Windows.Forms.TextBox loopValuesPicker;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.RadioButton singleStepRadio;
        private System.Windows.Forms.RadioButton loopRadio;
        private System.Windows.Forms.Label label1;
    }
}
