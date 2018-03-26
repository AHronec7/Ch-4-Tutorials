using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_5_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YellowButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YellowButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void RedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RedButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void WhiteButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteButton.Checked)

            {
                this.BackColor = Color.White;
            }
        }

        private void BackToNormalButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BackToNormalButton.Checked)

            {
                this.BackColor = SystemColors.Control;
            }


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
