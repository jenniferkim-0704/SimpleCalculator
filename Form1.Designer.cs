namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInputWindow = new TextBox();
            txtOutputWindow = new TextBox();
            lblSimpleCalculator = new Label();
            btnCE = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDivision = new Button();
            btnSeven = new Button();
            btnFour = new Button();
            btnOne = new Button();
            btnPlusMainus = new Button();
            btnEight = new Button();
            btnFive = new Button();
            btnTwo = new Button();
            btnZero = new Button();
            btnNine = new Button();
            btnSix = new Button();
            btnThree = new Button();
            btnDot = new Button();
            btnMultiplication = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtInputWindow
            // 
            txtInputWindow.Font = new Font("맑은 고딕", 15F);
            txtInputWindow.Location = new Point(154, 114);
            txtInputWindow.Name = "txtInputWindow";
            txtInputWindow.Size = new Size(468, 41);
            txtInputWindow.TabIndex = 0;
            // 
            // txtOutputWindow
            // 
            txtOutputWindow.Font = new Font("맑은 고딕", 15F);
            txtOutputWindow.Location = new Point(154, 161);
            txtOutputWindow.Name = "txtOutputWindow";
            txtOutputWindow.Size = new Size(468, 41);
            txtOutputWindow.TabIndex = 1;
            // 
            // lblSimpleCalculator
            // 
            lblSimpleCalculator.AutoSize = true;
            lblSimpleCalculator.Font = new Font("Times New Roman", 45F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSimpleCalculator.Location = new Point(85, 9);
            lblSimpleCalculator.Name = "lblSimpleCalculator";
            lblSimpleCalculator.Size = new Size(613, 85);
            lblSimpleCalculator.TabIndex = 2;
            lblSimpleCalculator.Text = "Simple Calculator";
            // 
            // btnCE
            // 
            btnCE.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCE.Location = new Point(154, 208);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(93, 42);
            btnCE.TabIndex = 3;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("맑은 고딕", 15F);
            btnC.Location = new Point(275, 208);
            btnC.Name = "btnC";
            btnC.Size = new Size(93, 42);
            btnC.TabIndex = 4;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("맑은 고딕", 15F);
            btnDel.Location = new Point(403, 208);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(93, 42);
            btnDel.TabIndex = 5;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("맑은 고딕", 15F);
            btnDivision.Location = new Point(529, 208);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(93, 42);
            btnDivision.TabIndex = 6;
            btnDivision.Text = "÷";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += button_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("맑은 고딕", 15F);
            btnSeven.Location = new Point(154, 256);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(93, 42);
            btnSeven.TabIndex = 7;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += button_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("맑은 고딕", 15F);
            btnFour.Location = new Point(154, 304);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(93, 42);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += button_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("맑은 고딕", 15F);
            btnOne.Location = new Point(154, 352);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(93, 42);
            btnOne.TabIndex = 9;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += button_Click;
            // 
            // btnPlusMainus
            // 
            btnPlusMainus.Font = new Font("맑은 고딕", 15F);
            btnPlusMainus.Location = new Point(154, 400);
            btnPlusMainus.Name = "btnPlusMainus";
            btnPlusMainus.Size = new Size(93, 42);
            btnPlusMainus.TabIndex = 10;
            btnPlusMainus.Text = "+/-";
            btnPlusMainus.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("맑은 고딕", 15F);
            btnEight.Location = new Point(275, 256);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(93, 42);
            btnEight.TabIndex = 11;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += button_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("맑은 고딕", 15F);
            btnFive.Location = new Point(275, 304);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(93, 42);
            btnFive.TabIndex = 12;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += button_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("맑은 고딕", 15F);
            btnTwo.Location = new Point(275, 352);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(93, 42);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += button_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("맑은 고딕", 15F);
            btnZero.Location = new Point(275, 400);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(93, 42);
            btnZero.TabIndex = 14;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += button_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("맑은 고딕", 15F);
            btnNine.Location = new Point(403, 256);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(93, 42);
            btnNine.TabIndex = 15;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += button_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("맑은 고딕", 15F);
            btnSix.Location = new Point(403, 304);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(93, 42);
            btnSix.TabIndex = 16;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += button_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("맑은 고딕", 15F);
            btnThree.Location = new Point(403, 352);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(93, 42);
            btnThree.TabIndex = 17;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += button_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("맑은 고딕", 15F);
            btnDot.Location = new Point(403, 400);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(93, 42);
            btnDot.TabIndex = 18;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += button_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("맑은 고딕", 15F);
            btnMultiplication.Location = new Point(529, 256);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(93, 42);
            btnMultiplication.TabIndex = 19;
            btnMultiplication.Text = "x";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += button_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("맑은 고딕", 15F);
            btnMinus.Location = new Point(529, 304);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(93, 42);
            btnMinus.TabIndex = 20;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += button_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("맑은 고딕", 15F);
            btnPlus.Location = new Point(529, 352);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(93, 42);
            btnPlus.TabIndex = 21;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 15F);
            btnEqual.Location = new Point(529, 400);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(93, 42);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEqual);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnMultiplication);
            Controls.Add(btnDot);
            Controls.Add(btnThree);
            Controls.Add(btnSix);
            Controls.Add(btnNine);
            Controls.Add(btnZero);
            Controls.Add(btnTwo);
            Controls.Add(btnFive);
            Controls.Add(btnEight);
            Controls.Add(btnPlusMainus);
            Controls.Add(btnOne);
            Controls.Add(btnFour);
            Controls.Add(btnSeven);
            Controls.Add(btnDivision);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(lblSimpleCalculator);
            Controls.Add(txtOutputWindow);
            Controls.Add(txtInputWindow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputWindow;
        private TextBox txtOutputWindow;
        private Label lblSimpleCalculator;
        private Button btnCE;
        private Button btnC;
        private Button btnDel;
        private Button btnDivision;
        private Button btnSeven;
        private Button btnFour;
        private Button btnOne;
        private Button btnPlusMainus;
        private Button btnEight;
        private Button btnFive;
        private Button btnTwo;
        private Button btnZero;
        private Button btnNine;
        private Button btnSix;
        private Button btnThree;
        private Button btnDot;
        private Button btnMultiplication;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnEqual;
    }
}
