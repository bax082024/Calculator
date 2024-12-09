namespace Basic_Calculator
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtDisplay;

        private void InitializeComponent()
        {
            txtDisplay = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtDisplay.Location = new System.Drawing.Point(20, 20);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new System.Drawing.Size(260, 35);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(320, 400);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Basic Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
