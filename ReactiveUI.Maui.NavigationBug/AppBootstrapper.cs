using Splat;

namespace ReactiveUI.Maui.NavigationBug
{
    public static class AppBootstrapper
    {
        public static MauiAppBuilder UseAppBootstrapper(this MauiAppBuilder builder)
        {
            var router = new RoutingState();
            var screen = new AppBootstrapScreen(router);
            Locator.CurrentMutable.RegisterConstant(screen, typeof(IScreen));
            Locator.CurrentMutable.Register(() => new MainPage(), typeof(IViewFor<MainViewModel>));
            router
                .NavigateAndReset
                .Execute(new MainViewModel(screen))
                .Subscribe();

            return builder;
        }

        public static Page CreateMainPage()
        {
            return new RoutedViewHost();
        }

        private class AppBootstrapScreen : ReactiveObject, IScreen
        {
            public AppBootstrapScreen(RoutingState router)
            {
                Router = router;
            }

            public RoutingState Router { get; protected set; }
        }
    }
}