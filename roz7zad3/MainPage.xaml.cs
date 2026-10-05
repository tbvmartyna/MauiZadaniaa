namespace roz7zad3
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            int r = (int)sliderR.Value;
            int g = (int)sliderG.Value;
            int b = (int)sliderB.Value;
            this.BackgroundColor = Color.FromRgb(r, g, b);
            sliderValueLabel.Text = $"R: {r}, G: {g}, B: {b}";

        }
    }
}
