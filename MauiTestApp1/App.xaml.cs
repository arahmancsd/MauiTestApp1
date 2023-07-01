namespace MauiTestApp1;

public partial class App : Application
{
    public App()
	{
		InitializeComponent();

        Current.RequestedThemeChanged += Current_RequestedThemeChanged;

        MainPage = new AppShell();
    }

    private void Current_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
    {
        // Don't handle events fired for old application instances
        // and cleanup the old instance's event handler
        if (Current != this && Current is App app)
        {
            Current.RequestedThemeChanged -= Current_RequestedThemeChanged;
            return;
        }

        Console.WriteLine($"{e.RequestedTheme}");

        UserAppTheme = e.RequestedTheme;
    }
}

