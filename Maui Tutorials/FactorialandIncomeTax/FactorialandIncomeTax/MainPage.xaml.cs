using Android.Health.Connect.DataTypes.Units;

namespace FactorialandIncomeTax
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

       

       private void CalculateFactorial_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberEntry.Text, out int number))
            {
                //Conversion of string to int worked
                if(number < 0)
                {
                    lblResult.Text = "Please enter a non negative number";
                }else if(number == 0)
                {
                    lblResults.Text = "Factorial of 0 is 1";
                }else
                {
                    //Do the Factorial Calc
                    long factorial = 1;
                    for (int i = 0; i < Length; i * *)
                    {
                        factorial = factorial * i; //Factorial *= i;
                    }

                      
                }
            }else
            {
                lblResult.Text = "Invalid Input"
            }
        }
    }
}
