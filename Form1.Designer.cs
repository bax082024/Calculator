namespace Basic_Calculator
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnProsent = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(305, 122);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(142, 31);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(305, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(31, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(342, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(31, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(379, 170);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(31, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(305, 199);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(31, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(342, 199);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(31, 23);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(379, 199);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(31, 23);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(305, 228);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(31, 23);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(342, 228);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(31, 23);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(379, 228);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(31, 23);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnResult.Location = new System.Drawing.Point(416, 257);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(31, 23);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(416, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(416, 199);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(31, 23);
            this.btnSubtract.TabIndex = 12;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(342, 257);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(31, 23);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(416, 170);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(31, 23);
            this.btnDivide.TabIndex = 14;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(379, 257);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(31, 23);
            this.btnDot.TabIndex = 15;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnProsent
            // 
            this.btnProsent.Location = new System.Drawing.Point(305, 257);
            this.btnProsent.Name = "btnProsent";
            this.btnProsent.Size = new System.Drawing.Size(31, 23);
            this.btnProsent.TabIndex = 16;
            this.btnProsent.Text = "%";
            this.btnProsent.UseVisualStyleBackColor = true;
            this.btnProsent.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(305, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProsent);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.OperationButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnProsent;
        private System.Windows.Forms.Button btnClear;
    }
}

