namespace rozz8zad2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonClicked(object? sender, EventArgs e)
        {
            string tekst = wiekEntry.Text;

            bool sukces = int.TryParse(tekst, out int wiek);

            if (sukces)

            {
                resultLabel.Text = "Wiek: " + wiek;
            }
            else
            {
                await DisplayAlert("Błąd", "Niepoprawny wiek", "OK");
            }
        }
    }
}