using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED a Constant
            //Data type is double
            //identifier is KM_PER_MILES
            double KM_PER_MILES = 1.6;
            double Miles = Convert.ToDouble(txtMiles.Text);

            double added = Miles + KM_PER_MILES;

            lblKiloResults.Text = String.Format("{0} Miles + {1} = {2} Kilometers", Miles, KM_PER_MILES,added);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}