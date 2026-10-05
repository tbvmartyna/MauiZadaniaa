namespace roz6zad3
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPlusClicked(object? sender, EventArgs e)
        {
            counterLabel.Text = (int.Parse(counterLabel.Text) + 1).ToString();
        }

        private void OnMinusClicked(object? sender, EventArgs e)
        {
            counterLabel.Text = (int.Parse(counterLabel.Text) - 1).ToString();
            if (int.Parse(counterLabel.Text) < 0)
            {
                counterLabel.Text = "0";
            }
        }

        private void OnResetClicked(object? sender, EventArgs e)
        {
            counterLabel.Text = "0";
        }
    }
}

      
         


