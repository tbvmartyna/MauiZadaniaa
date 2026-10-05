namespace roz5zad3
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private void OnPickerSelectedIndexChanged(object? sender, EventArgs e)
        {
            string selectedItem = picker.SelectedItem?.ToString() ?? "";
            ResultLabel.Text = $"Wybrano salę: {selectedItem}";
        }
        private void OnSubmitClicked(object? sender, EventArgs e)
        {
            
            string data = datePicker.Date?.ToString("dd/MM/yyyy") ?? "";
            double liczbaOsobValue = this.liczbaOsob.Value;
            int osoby = (int)liczbaOsobValue;

           

            ResultLabel.Text = $"Liczba osób: {osoby}, Data: {data}";
        }
    }
}
