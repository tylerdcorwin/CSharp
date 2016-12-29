namespace TCorwin_Lab1
{
    partial class Calc
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnOneOverX = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(16, 128);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(29, 23);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(51, 128);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(29, 23);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.NumDisplay);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(16, 15);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(178, 20);
            this.txtResult.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(121, 157);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(29, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Location = new System.Drawing.Point(51, 157);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(29, 23);
            this.btnPlusMinus.TabIndex = 5;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(16, 157);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(29, 23);
            this.btnZero.TabIndex = 4;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(51, 99);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(29, 23);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.NumDisplay);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(121, 99);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(29, 23);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(86, 99);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(29, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(16, 70);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(29, 23);
            this.btnSeven.TabIndex = 11;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(86, 157);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(29, 23);
            this.btnDot.TabIndex = 10;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(121, 128);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(29, 23);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(86, 128);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(29, 23);
            this.btnThree.TabIndex = 8;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(121, 70);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(29, 23);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(86, 70);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(29, 23);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(51, 70);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(29, 23);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.NumDisplay);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(16, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(156, 70);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(38, 23);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnOneOverX
            // 
            this.btnOneOverX.Location = new System.Drawing.Point(156, 99);
            this.btnOneOverX.Name = "btnOneOverX";
            this.btnOneOverX.Size = new System.Drawing.Size(38, 23);
            this.btnOneOverX.TabIndex = 19;
            this.btnOneOverX.Text = "1/x";
            this.btnOneOverX.UseVisualStyleBackColor = true;
            this.btnOneOverX.Click += new System.EventHandler(this.btnOneOverX_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(156, 128);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(38, 52);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(86, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 196);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnOneOverX);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "Calc";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnOneOverX;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
    }
}

