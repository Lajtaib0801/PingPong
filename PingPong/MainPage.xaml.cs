using PingPong.ViewModels;

namespace PingPong
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            playOneEnt.IsEnabled = playTwoEnt.IsEnabled = false;
            playOneEnt.IsEnabled = playTwoEnt.IsEnabled = true;
        }
    }
}