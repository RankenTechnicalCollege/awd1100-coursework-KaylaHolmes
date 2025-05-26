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
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtScoreFour_TextChanged(object sender, EventArgs e)
        {
            //Declared and Assigned a Constant
            //Data type is double
            //Identifier is Score_Average
            double Score_Average = 4;

            double ScoreOne = Convert.ToDouble(txtScoreOne.Text);
            double ScoreTwo = Convert.ToDouble(txtScoreTwo.Text);
            double ScoreThree = Convert.ToDouble(txtScoreThree.Text);
            double ScoreFour = Convert.ToDouble(txtScoreFour.Text);

            double added = ScoreOne + ScoreTwo + ScoreThree + ScoreFour / Score_Average;

            lblResults.Text = String.Format("The average of these four test scores is {0}",added);
        }
    }
}
