namespace ReactiveUI.Maui.NavigationBug;

public class MainViewModel : ReactiveObject, IRoutableViewModel
{
    public MainViewModel(IScreen hostScreen)
    {
        HostScreen = hostScreen;
        UrlPathSegment = "Main";
    }

    public string UrlPathSegment { get; }
    public IScreen HostScreen { get; }
}