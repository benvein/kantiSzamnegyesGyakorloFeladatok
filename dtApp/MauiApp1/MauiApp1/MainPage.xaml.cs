namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int countA = 0;
        int countB = 0;
        int countC = 0;
        int countD = 0;

        public MainPage()
        {
            One1.Text = $"{countA}";
            One2.Text = $"{countA + countB}";
            One3.Text = $"{countB}";
            Two1.Text = $"{countA + countC}";
            Two2.Text = $"{countA + countB + countC + countD}";
            Two3.Text = $"{countB + countD}";
            Three1.Text = $"{countC}";
            Three2.Text = $"{countC + countD}";
            Three3.Text = $"{countD}";

            InitializeComponent();
        }



        private void OnButtonAClicked(object sender, EventArgs e)
        {
            countA++;

        }

        private void OnButtonBClicked(object sender, EventArgs e)
        {
            countB++;
        }

        private void OnButtonCClicked(object sender, EventArgs e)
        {
            countC++;
        }

        private void OnButtonDClicked(object sender, EventArgs e)
        {
            countD++;
        }

        private void OnButtonClearClicked(object sender, EventArgs e)
        {
            countA = 0;
            countB = 0;
            countC = 0;
            countD = 0;
        }


    }
}
