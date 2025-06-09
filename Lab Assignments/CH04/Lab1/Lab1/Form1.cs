using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        private void btnConvertToKM_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is KM_PER_MILE

            double KM_PER_MILE = 1.6;
            double Miles = Convert.ToDouble(txtMiles.Text);
            
            double multiply1st = Miles * KM_PER_MILE;
            lblResults.Text = String.Format("{0} miles is {1} Kilometers", Miles, multiply1st);

        }

        private void btnConvertToMiles_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is Constant
            //Identifier is KM_PER_MILE

            double KM_PER_MILE = 1.6;
            double Kilometers = Convert.ToDouble(txtKilometers.Text);

            double multiply2nd = Kilometers / KM_PER_MILE;
            lblResults.Text = String.Format("{0} miles is {1} Kilometers", multiply2nd, Kilometers);


        }
    }
}
