namespace Tutorial_4_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HoursWorkedBox = new System.Windows.Forms.TextBox();
            this.HourlyPayBox = new System.Windows.Forms.TextBox();
            this.GrossPayBox = new System.Windows.Forms.TextBox();
            this.GrossPayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Worked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross Pay";
            // 
            // HoursWorkedBox
            // 
            this.HoursWorkedBox.Location = new System.Drawing.Point(264, 40);
            this.HoursWorkedBox.Name = "HoursWorkedBox";
            this.HoursWorkedBox.Size = new System.Drawing.Size(128, 20);
            this.HoursWorkedBox.TabIndex = 3;
            // 
            // HourlyPayBox
            // 
            this.HourlyPayBox.Location = new System.Drawing.Point(264, 154);
            this.HourlyPayBox.Name = "HourlyPayBox";
            this.HourlyPayBox.Size = new System.Drawing.Size(128, 20);
            this.HourlyPayBox.TabIndex = 4;
            // 
            // GrossPayBox
            // 
            this.GrossPayBox.Location = new System.Drawing.Point(264, 265);
            this.GrossPayBox.Name = "GrossPayBox";
            this.GrossPayBox.ReadOnly = true;
            this.GrossPayBox.Size = new System.Drawing.Size(128, 20);
            this.GrossPayBox.TabIndex = 5;
            // 
            // GrossPayButton
            // 
            this.GrossPayButton.Location = new System.Drawing.Point(25, 409);
            this.GrossPayButton.Name = "GrossPayButton";
            this.GrossPayButton.Size = new System.Drawing.Size(75, 23);
            this.GrossPayButton.TabIndex = 6;
            this.GrossPayButton.Text = "GrossPay";
            this.GrossPayButton.UseVisualStyleBackColor = true;
            this.GrossPayButton.Click += new System.EventHandler(this.GrossPayButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(200, 409);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(387, 409);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 496);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GrossPayButton);
            this.Controls.Add(this.GrossPayBox);
            this.Controls.Add(this.HourlyPayBox);
            this.Controls.Add(this.HoursWorkedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HoursWorkedBox;
        private System.Windows.Forms.TextBox HourlyPayBox;
        private System.Windows.Forms.TextBox GrossPayBox;
        private System.Windows.Forms.Button GrossPayButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

