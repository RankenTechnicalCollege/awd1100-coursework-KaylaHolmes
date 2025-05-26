using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class frmAverage : Form
    {
        public frmAverage()
        {
            InitializeComponent();
        }

        private void btnFindAverage_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED a Constant
            //Data Type is Double
            //identifier is RealOne
            double RealOne = Convert.ToDouble(txtReal1.Text);

            double RealTwo = Convert.ToDouble(txtReal2.Text);

            double RealThree = Convert.ToDouble(txtReal3.Text);

            double average = (RealOne + RealTwo + RealThree) / 3;

            lblResults.Text = String.Format("The average is: {0}", average);
        }
    }
}
