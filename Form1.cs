using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add items to the ComboBox
            cmbOperation.Items.Add("+");
            cmbOperation.Items.Add("-");
            cmbOperation.Items.Add("*");
            cmbOperation.Items.Add("/");
            cmbOperation.Items.Add("%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get numbers from text boxes
                double number1 = double.Parse(txtNumber1.Text);
                double number2 = double.Parse(txtNumber2.Text);

                // Get selected operation
                string operation = cmbOperation.SelectedItem.ToString();

                // Perform calculation
                double result;
                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0) throw new DivideByZeroException();
                        result = number1 / number2;
                        break;
                    default:
                        throw new InvalidOperationException("Unknown operation");
                }

                // Display result
                lblResult.Text = $"Result: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {

        }

        private void OperationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
