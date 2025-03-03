namespace WinUiHamburgerMenuMisssing;

public partial class FlyoutMainPage 
{
    private readonly NavigationPage _navigationPage;

    public FlyoutMainPage()
	{
		InitializeComponent();

        Detail = _navigationPage = new NavigationPage(new MainPage());
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        _navigationPage.PushAsync(new NewPage1());
    }
}