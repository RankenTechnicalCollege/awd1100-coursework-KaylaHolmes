using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED a Constant
            //Data type is double
            //Identifier is CM_PER_IN
            double CM_PER_IN = 2.54;

            double Inches = Convert.ToDouble(txtInches.Text);

            double multiply = CM_PER_IN * Inches;

            lblResults.Text = String.Format("{0} inches is {1} centimeters", Inches, multiply);
        }
    }
}
