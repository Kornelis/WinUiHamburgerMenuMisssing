namespace WinUiHamburgerMenuMisssing
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new FlyoutMainPage());
            window.Width = 740;
            window.Height = 500;
            return window;
        }

    }
}