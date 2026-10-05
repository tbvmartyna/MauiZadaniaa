namespace roz6zad2
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            sliderValueLabel.Text = $"Wartość suwaka: {e.NewValue:F0}";
            if (e.NewValue > 128)
            {
                sliderSLowoLabel.Text = "Wartość suwaka jest wysoka";
            }
            else
            {
                sliderSLowoLabel.Text = "Wartość suwaka jest niska";
            }
        }
    }
}

             
        