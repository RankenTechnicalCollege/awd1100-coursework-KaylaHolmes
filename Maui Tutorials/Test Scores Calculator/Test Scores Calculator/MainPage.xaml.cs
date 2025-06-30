namespace Test_Scores_Calculator
{
    public partial class MainPage : ContentPage
    {
        int totalScore = 0; //Accumulated score
        int testscoreCount = 0; //Number of tests taken
        float averageScore = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddScoreClicked(object sender, EventArgs e)
        {
            //Validate the users input with tryparse
            //Get the input and validate the input
            if(int.TryParse(txtScoreEntry.Text, out int testscore) && testscore >= 0 && testscore <=100)
            {
                //Conversion worked
                ++testscoreCount; //Increment the number of tests taken


                //Math 
                totalScore = totalScore + testscore;

                //Int division is a problem
                //To solve the problem, we convert the variable temp, to a float
                averageScore = (float)testscore / testscoreCount; //Calculate the average score

                //Output the result to the label
                lblTotalScore.Text = $"  {totalScore}";
                lblScoreCount.Text = $"  {testscoreCount}";
                lblAverage.Text = $"   {averageScore}";
            }
            else
            {
                //Conversion failed
                DisplayAlert("Invlaid Input", "Please enter a valid score.", "OK");
            }

            txtScoreEntry.Text = string.Empty;  //Clear the input field
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            lblTotalScore.Text = string.Empty;
            lblScoreCount.Text = string.Empty;
            lblAverage.Text = string.Empty;
            txtScoreEntry.Text = string.Empty; //Clear the input field
            totalScore = 0; //Reset the total score
            testscoreCount = 0; //Reset the number of tests taken
            averageScore = 0; //Reset the average score
        }

        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
    }
}
