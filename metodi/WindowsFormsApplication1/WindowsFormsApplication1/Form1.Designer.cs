namespace WindowsFormsApplication1
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
            this.firstParameter = new System.Windows.Forms.TextBox();
            this.secondParameter = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.mod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstParameter
            // 
            this.firstParameter.Location = new System.Drawing.Point(31, 47);
            this.firstParameter.Name = "firstParameter";
            this.firstParameter.Size = new System.Drawing.Size(100, 20);
            this.firstParameter.TabIndex = 0;
            // 
            // secondParameter
            // 
            this.secondParameter.Location = new System.Drawing.Point(225, 47);
            this.secondParameter.Name = "secondParameter";
            this.secondParameter.Size = new System.Drawing.Size(100, 20);
            this.secondParameter.TabIndex = 1;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(144, 44);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(75, 23);
            this.addition.TabIndex = 2;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(144, 73);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(75, 23);
            this.substraction.TabIndex = 3;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(144, 102);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 4;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(144, 131);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(347, 49);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 6;
            this.equal.Text = "=";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(379, 49);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(137, 20);
            this.result.TabIndex = 7;
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(144, 160);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(75, 23);
            this.mod.TabIndex = 8;
            this.mod.Text = "Mod";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 195);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.secondParameter);
            this.Controls.Add(this.firstParameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstParameter;
        private System.Windows.Forms.TextBox secondParameter;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button mod;
    }
}

