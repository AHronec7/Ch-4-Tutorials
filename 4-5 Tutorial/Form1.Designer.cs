namespace _4_5_Tutorial
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
            this.ColorGroupBox = new System.Windows.Forms.GroupBox();
            this.YellowButton = new System.Windows.Forms.RadioButton();
            this.RedButton = new System.Windows.Forms.RadioButton();
            this.WhiteButton = new System.Windows.Forms.RadioButton();
            this.BackToNormalButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ColorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColorGroupBox
            // 
            this.ColorGroupBox.Controls.Add(this.BackToNormalButton);
            this.ColorGroupBox.Controls.Add(this.WhiteButton);
            this.ColorGroupBox.Controls.Add(this.RedButton);
            this.ColorGroupBox.Controls.Add(this.YellowButton);
            this.ColorGroupBox.Location = new System.Drawing.Point(52, 27);
            this.ColorGroupBox.Name = "ColorGroupBox";
            this.ColorGroupBox.Size = new System.Drawing.Size(317, 263);
            this.ColorGroupBox.TabIndex = 0;
            this.ColorGroupBox.TabStop = false;
            this.ColorGroupBox.Text = "Select a color";
            // 
            // YellowButton
            // 
            this.YellowButton.AutoSize = true;
            this.YellowButton.Location = new System.Drawing.Point(57, 46);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(56, 17);
            this.YellowButton.TabIndex = 0;
            this.YellowButton.TabStop = true;
            this.YellowButton.Text = "Yellow";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.CheckedChanged += new System.EventHandler(this.YellowButton_CheckedChanged);
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Location = new System.Drawing.Point(57, 96);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(45, 17);
            this.RedButton.TabIndex = 1;
            this.RedButton.TabStop = true;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.CheckedChanged += new System.EventHandler(this.RedButton_CheckedChanged);
            // 
            // WhiteButton
            // 
            this.WhiteButton.AutoSize = true;
            this.WhiteButton.Location = new System.Drawing.Point(57, 153);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(53, 17);
            this.WhiteButton.TabIndex = 2;
            this.WhiteButton.TabStop = true;
            this.WhiteButton.Text = "White";
            this.WhiteButton.UseVisualStyleBackColor = true;
            this.WhiteButton.CheckedChanged += new System.EventHandler(this.WhiteButton_CheckedChanged);
            // 
            // BackToNormalButton
            // 
            this.BackToNormalButton.AutoSize = true;
            this.BackToNormalButton.Location = new System.Drawing.Point(57, 211);
            this.BackToNormalButton.Name = "BackToNormalButton";
            this.BackToNormalButton.Size = new System.Drawing.Size(96, 17);
            this.BackToNormalButton.TabIndex = 3;
            this.BackToNormalButton.TabStop = true;
            this.BackToNormalButton.Text = "Back to normal";
            this.BackToNormalButton.UseVisualStyleBackColor = true;
            this.BackToNormalButton.CheckedChanged += new System.EventHandler(this.BackToNormalButton_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(129, 321);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 369);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ColorGroupBox);
            this.Name = "Form1";
            this.Text = "Colors";
            this.ColorGroupBox.ResumeLayout(false);
            this.ColorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ColorGroupBox;
        private System.Windows.Forms.RadioButton BackToNormalButton;
        private System.Windows.Forms.RadioButton WhiteButton;
        private System.Windows.Forms.RadioButton RedButton;
        private System.Windows.Forms.RadioButton YellowButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

