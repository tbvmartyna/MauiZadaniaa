namespace roz7zad2
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCornsikClicked(object? sender, EventArgs e)
        {
            colorLabel.Text = "Aktualny kolor: Cornsik(#FFF8DC)";
            BackgroundColor = Color.FromArgb("#FFF8DC");
        }

        private void OnPeruClicked(object? sender, EventArgs e)
        {
            colorLabel.Text = "AKtualny kolor: Peru(#CD853F)";
            BackgroundColor = Color.FromArgb("#CD853F");
        }
    }
}

