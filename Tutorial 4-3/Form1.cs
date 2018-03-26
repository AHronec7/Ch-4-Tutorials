using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                const decimal minimumsalary = 40000;
                const int minimumyearsonjob = 2;


                // declare the variables 

                decimal salary;
                int yearsonjob;



                // get the years at current job and salary

                salary = decimal.Parse(AnnualSalaryBox.Text);

                yearsonjob = int.Parse(CurrentJobYearsBox.Text);


                if (salary >= minimumsalary)

                {

                    if (yearsonjob >= minimumyearsonjob)
                    {
                        LoanDecisionBox.Text = ("you qualify for a loan");
                    }

                    else
                    {

                        LoanDecisionBox.Text = ("you DONOT qualify for loan");

                    }


                }
            }   


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AnnualSalaryBox.Text = "";
            CurrentJobYearsBox.Text = "";
            LoanDecisionBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
