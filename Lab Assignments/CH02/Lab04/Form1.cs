using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmLab04 : Form
    {
        public frmLab04()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is DAYS_RENTED
            double DAYS_RENTED = 100;

            double Days = Convert.ToDouble(txtDaysRented.Text);

            double Multiply1st = Days * DAYS_RENTED;

            lblDaysResults.Text = String.Format("Total for Days ${0}", Multiply1st);

            double MilesDriven = .50;

            double Miles = Convert.ToDouble(txtMiles.Text);

            double Multiply2nd = MilesDriven * Miles;

            lblMilesResults.Text = String.Format("Total for Miles ${0}", Multiply2nd);

            double added = Multiply2nd + Multiply1st;

            lblAmountDue.Text = String.Format("Amount Due is ${0}", added);
        }
    }
}
