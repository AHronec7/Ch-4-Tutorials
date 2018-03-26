using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_Four_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                const double highscore = 95.0;
                double test1, test2, test3, average;


                // get the test scores from the textboxes

                test1 = double.Parse(Test1Box.Text);
                test2 = double.Parse(Test2Box.Text);
                test3 = double.Parse(Test3Box.Text);

                // calculate the average score of the tests


                average = (test1 + test2 + test3) / 3.0;

                AverageTestBox.Text = average.ToString("n1");

                //if the average is a highscore, congratulate the user with a message:

                if (average > highscore)
                {
                    MessageBox.Show("congrats on the test");
                }

            }

            catch (Exception ex)

            {

                // display default error message

                MessageBox.Show(ex.Message);





            }
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clear the text boxes for a new input

            Test1Box.Text = "";
            Test2Box.Text = "";
            Test3Box.Text = "";
            AverageTestBox.Text = "";

            //reset the focus to test1

            Test1Box.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
