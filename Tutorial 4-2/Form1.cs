using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GrossPayButton_Click(object sender, EventArgs e)
        {
            try
            {

                // named constants

                const decimal basehour = 40;
                const decimal multiplier = 1.5m;

                //local variables declared 


                decimal hoursworked;
                decimal hourlypayrate;
                decimal basepay;
                decimal overtimehours;
                decimal overtimepay;
                decimal grosspay;


                // get the hours worked and the hourly pay rate 

                hoursworked = decimal.Parse(HoursWorkedBox.Text);
                hourlypayrate = decimal.Parse(HourlyPayBox.Text);


                // determine the gross pay 

                if (hoursworked > basehour)

                {
                    // calculate the base pay 

                    basepay = hourlypayrate * basehour;

                    //calculate the number of overtime hours 

                    overtimehours = hoursworked - basehour;

                    // calculate the overtime pay

                    overtimepay = overtimehours * hourlypayrate * multiplier;

                    //calculate the gross pay

                    grosspay = basepay + overtimepay;


                    //display the gross pay(output)



                }

                else
                {
                    // calculate the gross pay 

                    grosspay = hoursworked * hourlypayrate;


                }

                GrossPayBox.Text = grosspay.ToString("c");

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // clear out the text boxes

            HoursWorkedBox.Text = "";
            HourlyPayBox.Text = "";
            GrossPayBox.Text = "";


            // reset focus 

            HoursWorkedBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
