using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class frmEX3 : Form
    {
        public frmEX3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAmountDue_Click(object sender, EventArgs e)
        {
            //Declared and ASSIGNED is Constant
            //Data type is double
            //identifier is Price_Per_Shirt
            double Price_Per_Shirt = 14.99;

            double Quantity = Convert.ToDouble(txtQuantity.Text);

            double multiply = Price_Per_Shirt * Quantity;

            lblTotalPrice.Text = String.Format("Total Price: ${0}", multiply);
        
            //Declared and ASSIGNED is Constant
            //Data type is double
            //identifier is Sales_Tax
            double Sales_Tax = .08;

            double Total_Price = Convert.ToDouble(lblTotalPrice.Text);

            double percentage = Sales_Tax * Total_Price;

            lblSalesTax.Text = String.Format("Sales Tax: ${0}", percentage);
           
            //Declared and ASSIGNED is Constant
            //Data type is double
            //identifier is Taxes
            double Taxes = Convert.ToDouble(lblSalesTax.Text);

            double added = Taxes + Total_Price;

            lblAmountDue.Text = String.Format("Amount Due: ${0}", added);
        }
    }
}