using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double eng, math, science, fil, hist;
        double average;
        string name;

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // Attempt to parse the grade inputs
            if (double.TryParse(txtEnglish.Text, out eng) &&
                double.TryParse(txtMath.Text, out math) &&
                double.TryParse(txtScience.Text, out science) &&
                double.TryParse(txtFilipino.Text, out fil) &&
                double.TryParse(txtHistory.Text, out hist))
            {
                // Retrieve the student's name
                name = txtNames.Text;

                // Calculate the average grade
                average = (eng + math + science + fil + hist) / 5;

                // Determine if the student passed or failed
                Result.Text = average >= 75 ? "The student passed." : "The student failed.";

                // Display the average with 2 decimal places
                label8.Text = $"The general average of {name} is {average:F2}.";
            }
            else
            {
                // Show an error message if input is invalid
                MessageBox.Show("Please enter valid numbers for all grades.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization code (if needed)
        }

        // Unused event handlers can be removed or left empty
        private void label1_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void displayResult_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label8_Click_1(object sender, EventArgs e) { }
        private void txtEnglish_TextChanged(object sender, EventArgs e) { }
        private void txtMath_TextChanged(object sender, EventArgs e) { }
        private void txtScience_TextChanged(object sender, EventArgs e) { }
        private void txtFilipino_TextChanged(object sender, EventArgs e) { }
        private void txtHistory_TextChanged(object sender, EventArgs e) { }
    }
}
