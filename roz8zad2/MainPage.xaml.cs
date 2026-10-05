namespace roz8zad2
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object? sender, EventArgs e)
        {
            int wiek = int.Parse(wiekEntry.Text);
            if (wiek < 1 && wiek > 120)
            {
                resultLabel.Text = "Wiek musi być z zakresu od 1 do 120.";
            }
            else
            {
                resultLabel.Text = $"Podany wiek to {wiek}.";
            }
            else if (wiek != int.TryParse(wiekEntry.Text, out wiek))
            {
                DisplayAlert= ("Błąd", "Wiek musi być liczbą całkowitą.", "OK");
            }
        }
    }
}
