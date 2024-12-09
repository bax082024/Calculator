using System;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        private double _firstNumber = 0;
        private string _currentOperation = string.Empty;

        public Form1()
        {
            InitializeComponent();
            CreateButtons(); // Dynamically create buttons for numbers and operations
        }

        private void CreateButtons()
        {
            int buttonWidth = 60, buttonHeight = 50;
            int startX = 20, startY = 70; // Starting position for buttons
            int spacing = 10; // Space between buttons

            // Background color for the form
            this.BackColor = System.Drawing.Color.LightGray;

            // Number buttons (1-9)
            for (int i = 1; i <= 9; i++)
            {
                Button numberButton = new Button
                {
                    Text = i.ToString(),
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point(
                        startX + ((i - 1) % 3) * (buttonWidth + spacing),
                        startY + ((i - 1) / 3) * (buttonHeight + spacing)
                    ),
                    BackColor = System.Drawing.Color.WhiteSmoke // Background for number buttons
                };
                numberButton.Click += NumberButton_Click;
                this.Controls.Add(numberButton);
            }

            // Place '0' button
            Button zeroButton = new Button
            {
                Text = "0",
                Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                Location = new System.Drawing.Point(
                    startX + buttonWidth + spacing,
                    startY + 3 * (buttonHeight + spacing)
                ),
                BackColor = System.Drawing.Color.WhiteSmoke
            };
            zeroButton.Click += NumberButton_Click;
            this.Controls.Add(zeroButton);

            // Operation buttons
            string[] operations = { "+", "-", "*", "/", "%" };
            for (int i = 0; i < operations.Length; i++)
            {
                Button operationButton = new Button
                {
                    Text = operations[i],
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point(
                        startX + 3 * (buttonWidth + spacing),
                        startY + i * (buttonHeight + spacing)
                    ),
                    BackColor = System.Drawing.Color.LightBlue // Background for operation buttons
                };
                operationButton.Click += OperationButton_Click;
                this.Controls.Add(operationButton);
            }

            // Equals button spanning the bottom
            Button equalsButton = new Button
            {
                Text = "=",
                Size = new System.Drawing.Size(buttonWidth * 2 + spacing, buttonHeight),
                Location = new System.Drawing.Point(
                    startX + buttonWidth + spacing,
                    startY + 4 * (buttonHeight + spacing)
                ),
                BackColor = System.Drawing.Color.LightGreen // Background for equals button
            };
            equalsButton.Click += EqualsButton_Click;
            this.Controls.Add(equalsButton);

            // Clear button
            Button clearButton = new Button
            {
                Text = "C",
                Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                Location = new System.Drawing.Point(
                    startX,
                    startY + 4 * (buttonHeight + spacing)
                ),
                BackColor = System.Drawing.Color.Salmon // Background for clear button
            };
            clearButton.Click += ClearButton_Click;
            this.Controls.Add(clearButton);
        }


        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            txtDisplay.Text += button.Text; // Append the clicked number to the display
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (double.TryParse(txtDisplay.Text, out _firstNumber))
            {
                _currentOperation = button.Text; // Store the selected operation
                txtDisplay.Clear();              // Clear the display for the next number
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double secondNumber))
            {
                double result = _currentOperation switch
                {
                    "+" => _firstNumber + secondNumber,
                    "-" => _firstNumber - secondNumber,
                    "*" => _firstNumber * secondNumber,
                    "/" => secondNumber != 0 ? _firstNumber / secondNumber : throw new DivideByZeroException(),
                    "%" => _firstNumber % secondNumber,
                    _ => 0
                };

                txtDisplay.Text = result.ToString(); // Display the result
                _currentOperation = string.Empty;    // Clear the operation
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;    // Clear the display
            _firstNumber = 0;                  // Reset the first number
            _currentOperation = string.Empty;  // Clear the current operation
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
