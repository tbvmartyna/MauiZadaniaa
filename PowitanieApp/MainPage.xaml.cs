namespace PowitanieApp
{
    public partial class MainPage : ContentPage
    {
        int liczbaw = 0;
        int liczbar = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            liczbaw++;
            WelcomeLabel.Text = "Aplikacja działa poprawnie";
            Licznik.Text = $"Kliknięcia: {liczbaw}";
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClicked2(object? sender, EventArgs e)
        {
            liczbar++;
            WelcomeLabel.Text = "Witamy w aplikacji";
            Licznik2.Text =$"Kliknięcia: {liczbar}";



        }
    }
}
