namespace ReactiveUI.Maui.NavigationBug;

public partial class App
{
    public App()
    {
        InitializeComponent();

        MainPage = AppBootstrapper.CreateMainPage();
    }
}