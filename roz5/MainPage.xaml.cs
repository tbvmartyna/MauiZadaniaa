namespace roz5
{
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
        {
            suwakValue.Text = $"Ocena: {Math.Round(e.NewValue)}";
        }
    }
}
