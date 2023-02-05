namespace Calculator
{
    partial class FrmClaculator
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
            this.TxtScreen = new System.Windows.Forms.TextBox();
            this.LblHistory = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnSum = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtScreen
            // 
            this.TxtScreen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtScreen.Location = new System.Drawing.Point(15, 47);
            this.TxtScreen.Name = "TxtScreen";
            this.TxtScreen.Size = new System.Drawing.Size(329, 43);
            this.TxtScreen.TabIndex = 2;
            this.TxtScreen.Text = "0";
            this.TxtScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtScreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtScreen_KeyPress);
            // 
            // LblHistory
            // 
            this.LblHistory.AutoSize = true;
            this.LblHistory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblHistory.ForeColor = System.Drawing.Color.Navy;
            this.LblHistory.Location = new System.Drawing.Point(15, 9);
            this.LblHistory.Name = "LblHistory";
            this.LblHistory.Size = new System.Drawing.Size(28, 25);
            this.LblHistory.TabIndex = 3;
            this.LblHistory.Text = "--";
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(15, 349);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 75);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(96, 349);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(75, 75);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(177, 349);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(75, 75);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(15, 268);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(75, 75);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(96, 268);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(75, 75);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(177, 268);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(75, 75);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(15, 187);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(75, 75);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(96, 187);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(75, 75);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(177, 187);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(75, 75);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(269, 268);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(75, 75);
            this.BtnSum.TabIndex = 13;
            this.BtnSum.Text = "+";
            this.BtnSum.UseVisualStyleBackColor = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Location = new System.Drawing.Point(269, 184);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(75, 75);
            this.BtnMultiply.TabIndex = 14;
            this.BtnMultiply.Text = "*";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(269, 106);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(75, 72);
            this.BtnDivide.TabIndex = 15;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(269, 430);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(75, 103);
            this.BtnResult.TabIndex = 16;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.Location = new System.Drawing.Point(135, 430);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(114, 103);
            this.BtnDot.TabIndex = 17;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(15, 430);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(114, 103);
            this.Btn0.TabIndex = 18;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Location = new System.Drawing.Point(269, 349);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(75, 75);
            this.BtnMinus.TabIndex = 19;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(135, 106);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(117, 75);
            this.BtnRemove.TabIndex = 20;
            this.BtnRemove.Text = "C";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(12, 106);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(117, 75);
            this.BtnClear.TabIndex = 21;
            this.BtnClear.Text = "CE";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // FrmClaculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 546);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnSum);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.LblHistory);
            this.Controls.Add(this.TxtScreen);
            this.Name = "FrmClaculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox TxtScreen;
        private Label LblHistory;
        private Button Btn1;
        private Button Btn2;
        private Button Btn3;
        private Button Btn4;
        private Button Btn5;
        private Button Btn6;
        private Button Btn7;
        private Button Btn8;
        private Button Btn9;
        private Button BtnSum;
        private Button BtnMultiply;
        private Button BtnDivide;
        private Button BtnResult;
        private Button BtnDot;
        private Button Btn0;
        private Button BtnMinus;
        private Button BtnRemove;
        private Button BtnClear;
    }
}