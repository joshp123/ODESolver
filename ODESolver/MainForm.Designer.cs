namespace ODESolver
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comparisonTable1 = new ODESolver.ComparisonTable();
            this.SuspendLayout();
            // 
            // comparisonTable1
            // 
            this.comparisonTable1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comparisonTable1.Location = new System.Drawing.Point(0, 0);
            this.comparisonTable1.Name = "comparisonTable1";
            this.comparisonTable1.Size = new System.Drawing.Size(1005, 796);
            this.comparisonTable1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 796);
            this.Controls.Add(this.comparisonTable1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComparisonTable comparisonTable1;
    }
}

