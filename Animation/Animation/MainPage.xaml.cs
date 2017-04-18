using Xamarin.Forms;

namespace Animation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            animation();
        }

        public async void animation() {

            await lbl.TranslateTo(-100, 0, 1000);    // Move left
            await lbl.TranslateTo(-100, -100, 1000); // Move up
            await lbl.TranslateTo(100, 100, 2000);   // Move diagonally down and right
            await lbl.TranslateTo(0, 100, 1000);     // Move left
            await lbl.TranslateTo(0, 0, 1000);       // Move up

            await lbl.TranslateTo(0, 200, 2000, Easing.BounceIn);
            await lbl.ScaleTo(2, 2000, Easing.CubicIn);
            await lbl.RotateTo(360, 2000, Easing.SinInOut);
            await lbl.ScaleTo(1, 2000, Easing.CubicOut);
            await lbl.TranslateTo(0, -200, 2000, Easing.BounceOut);
            
            await lbl.TranslateTo(0, 0, 2000);       // Move Down
        }
        
    }
}
