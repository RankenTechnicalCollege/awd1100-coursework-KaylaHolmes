using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmLab03 : Form
    {
        public frmLab03()
        {
            InitializeComponent();
        }

        private void lblEmployee3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void frmLab03_Load(object sender, EventArgs e)
        {


        }

        private void btnEmployee1_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is PERCENT_RAISE
            double PERCENT_RAISE = 0.04;

            double EmployeeA1 = Convert.ToDouble(txtSalaries1.Text);

            double multiply1st = PERCENT_RAISE * EmployeeA1;

            double Added1st = multiply1st + EmployeeA1;

            lblResults1.Text = String.Format("${0}", Added1st);

            double multiply2nd = PERCENT_RAISE * Added1st;

            double Added2nd = multiply2nd + Added1st;

            lblResults2.Text = String.Format("${0}", Added2nd);
        }

        private void btnCalculateB_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is PERCENT_RAISE
            double PERCENT_RAISE = 0.04;

            double Employeeb1 = Convert.ToDouble(txtSalaries2.Text);

            double multiply1st = PERCENT_RAISE * Employeeb1;

            double Added1st = multiply1st + Employeeb1;

            lblResultsB1.Text = String.Format("${0}", Added1st);

            double multiply2nd = PERCENT_RAISE * Added1st;

            double Added2nd = multiply2nd + Added1st;

            lblResultsB2.Text = String.Format("${0}", Added2nd);
        }

        private void btnCalculateC_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is PERCENT_RAISE
            double PERCENT_RAISE = 0.04;

            double EmployeeC1 = Convert.ToDouble(txtSalaries3.Text);

            double multiply1st = PERCENT_RAISE * EmployeeC1;

            double Added1st = multiply1st + EmployeeC1;

            lblResultsC1.Text = String.Format("${0}", Added1st);

            double multiply2nd = PERCENT_RAISE * Added1st;

            double Added2nd = multiply2nd + Added1st;

            lblResultsC2.Text = String.Format("${0}", Added2nd);
        }
    }
}
