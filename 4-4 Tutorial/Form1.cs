using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_4_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;

            //validate the milestextbox

            if (double.TryParse(MilesTextBox.Text, out miles))

            {
                if (double.TryParse(GallonsTextBox.Text, out gallons))

                {
                    // calculate MPG

                    mpg = miles / gallons;

                    //display the MPG in the labelbox

                    MPGBox.Text = mpg.ToString("n1");

                }

                else
                {
                    // display an error message 

                    MessageBox.Show("invalid input for gallons");
                }

            }

            else
            {
                MessageBox.Show("invalid input for miles");

            }











        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}