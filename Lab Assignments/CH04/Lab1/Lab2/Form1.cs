using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmChickenFarmer : Form
    {
        public frmChickenFarmer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED a constant
            //Data type is constant
            //Identifier is Chicken1
            
            double Chicken1 = Convert.ToDouble(txtChicken1.Text);
            double Chicken2 = Convert.ToDouble(txtChicken2.Text);
            double Chicken3 = Convert.ToDouble(txtChicken3.Text);
            double Chicken4 = Convert.ToDouble(txtChicken4.Text);

            double sum = Chicken1 + Chicken2 + Chicken3 + Chicken4;

            double dozen = sum / 12;

            lblResults.Text = String.Format("{0} eggs total, or {1} dozen", sum, dozen);

        }
    }
}
