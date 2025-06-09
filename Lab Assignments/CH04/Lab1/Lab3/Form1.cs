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
    public partial class frmPayrollProtection : Form
    {
        public frmPayrollProtection()
        {
            InitializeComponent();
        }

        private void frmPayrollProtection_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is Percent_Raise

            double Percent_Raise = .04;

            double Salary1 = Convert.ToDouble(txtSalary1.Text);
            double Salary2 = Convert.ToDouble(txtSalary2.Text);
            double Salary3 = Convert.ToDouble(txtSalary3.Text);

            //Employee 1
            lblName1.Text = String.Format("{0}", txtEmployee1.Text);
            lblResultsA1.Text = String.Format("${0}", Salary1);
           
            double A1 = Salary1 * Percent_Raise;
            double AddedA1 = A1 + Salary1;
            lblResultsA2.Text = String.Format("${0}", AddedA1);

            double A2 = AddedA1 * Percent_Raise;
            double AddedA2 = A2 + AddedA1;
            lblResultsA3.Text = String.Format("${0}", AddedA2);

            //Employee 2
            lblName2.Text = String.Format("{0}", txtEmployee2.Text);
            lblResultsB1.Text = String.Format("${0}", Salary2);

            double B1 = Salary2 * Percent_Raise;
            double AddedB1 = B1 + Salary2;
            lblResultsB2.Text = String.Format("${0}", AddedB1);

            double B2 = AddedB1 * Percent_Raise;
            double AddedB2 = A2 + AddedB1;
            lblResultsB3.Text = String.Format("${0}", AddedB2);

            //Employee 3
            lblName3.Text = String.Format("{0}", txtEmployee3.Text);
            lblResultsC1.Text = String.Format("${0}", Salary3);

            double C1 = Salary3 * Percent_Raise;
            double AddedC1 = C1 + Salary3;
            lblResultsC2.Text = String.Format("${0}", AddedC1);

            double C2 = AddedC1 * Percent_Raise;
            double AddedC2 = C2 + AddedC1;
            lblResultsC3.Text = String.Format("${0}", AddedC2);

        }
    }
}
