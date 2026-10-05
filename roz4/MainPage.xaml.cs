namespace roz4
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSubmitClicked(object? sender, EventArgs e)
        {
            string imie = NameEntry.Text;
            string nazwisko = SurnameEntry.Text;
            string certyfikat = przelacznik.IsToggled ? "Tak" : "Nie";
            string uwagi = UwagiEditor.Text;
            string formakursu =radioButton1.IsChecked ? "Stacjonarnie" : radioButton2.IsChecked ? "Online" : radioButton3.IsChecked ? "Hybrydowo" : "Nie wybrano";

            if (imie == null || nazwisko == null)

            {

                
                ResultLabel.Text = "Najpierw podaj imię i nazwisko";

                return; 

            }

            ResultLabel.Text = $"Imię: {imie}\nNazwisko: {nazwisko}\nCertyfikat: {certyfikat}\nUwagi: {uwagi} \nForma kursu: {formakursu}";

        }

    }
}
