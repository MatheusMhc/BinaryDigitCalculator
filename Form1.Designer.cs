namespace BinaryDigitCalculator
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
            chk32 = new CheckBox();
            chk16 = new CheckBox();
            chk8 = new CheckBox();
            chk4 = new CheckBox();
            chk2 = new CheckBox();
            chk1 = new CheckBox();
            chk64 = new CheckBox();
            lblBinary = new Label();
            lblDecimal = new Label();
            SuspendLayout();
            // 
            // chk32
            // 
            chk32.AutoSize = true;
            chk32.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk32.Location = new Point(142, 105);
            chk32.Name = "chk32";
            chk32.Size = new Size(53, 32);
            chk32.TabIndex = 6;
            chk32.Text = "32";
            chk32.UseVisualStyleBackColor = true;
            chk32.CheckedChanged += chk_CheckedChanged;
            // 
            // chk16
            // 
            chk16.AutoSize = true;
            chk16.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk16.Location = new Point(201, 105);
            chk16.Name = "chk16";
            chk16.Size = new Size(53, 32);
            chk16.TabIndex = 5;
            chk16.Text = "16";
            chk16.UseVisualStyleBackColor = true;
            chk16.CheckedChanged += chk_CheckedChanged;
            // 
            // chk8
            // 
            chk8.AutoSize = true;
            chk8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk8.Location = new Point(260, 105);
            chk8.Name = "chk8";
            chk8.Size = new Size(42, 32);
            chk8.TabIndex = 4;
            chk8.Text = "8";
            chk8.UseVisualStyleBackColor = true;
            chk8.CheckedChanged += chk_CheckedChanged;
            // 
            // chk4
            // 
            chk4.AutoSize = true;
            chk4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk4.Location = new Point(308, 105);
            chk4.Name = "chk4";
            chk4.Size = new Size(42, 32);
            chk4.TabIndex = 3;
            chk4.Text = "4";
            chk4.UseVisualStyleBackColor = true;
            chk4.CheckedChanged += chk_CheckedChanged;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk2.Location = new Point(356, 105);
            chk2.Name = "chk2";
            chk2.Size = new Size(42, 32);
            chk2.TabIndex = 2;
            chk2.Text = "2";
            chk2.UseVisualStyleBackColor = true;
            chk2.CheckedChanged += chk_CheckedChanged;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk1.Location = new Point(404, 105);
            chk1.Name = "chk1";
            chk1.Size = new Size(42, 32);
            chk1.TabIndex = 1;
            chk1.Text = "1";
            chk1.UseVisualStyleBackColor = true;
            chk1.CheckedChanged += chk_CheckedChanged;
            // 
            // chk64
            // 
            chk64.AutoSize = true;
            chk64.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chk64.Location = new Point(83, 105);
            chk64.Name = "chk64";
            chk64.Size = new Size(53, 32);
            chk64.TabIndex = 7;
            chk64.Text = "64";
            chk64.UseVisualStyleBackColor = true;
            chk64.CheckedChanged += chk_CheckedChanged;
            // 
            // lblBinary
            // 
            lblBinary.AutoSize = true;
            lblBinary.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBinary.Location = new Point(78, 26);
            lblBinary.Name = "lblBinary";
            lblBinary.Size = new Size(66, 28);
            lblBinary.TabIndex = 13;
            lblBinary.Text = "Binary";
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDecimal.Location = new Point(78, 62);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(82, 28);
            lblDecimal.TabIndex = 14;
            lblDecimal.Text = "Decimal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 414);
            Controls.Add(lblDecimal);
            Controls.Add(lblBinary);
            Controls.Add(chk64);
            Controls.Add(chk1);
            Controls.Add(chk2);
            Controls.Add(chk4);
            Controls.Add(chk8);
            Controls.Add(chk16);
            Controls.Add(chk32);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chk32;
        private CheckBox chk16;
        private CheckBox chk8;
        private CheckBox chk4;
        private CheckBox chk2;
        private CheckBox chk1;
        private CheckBox chk64;
        private Label lblBinary;
        private Label lblDecimal;
    }
}