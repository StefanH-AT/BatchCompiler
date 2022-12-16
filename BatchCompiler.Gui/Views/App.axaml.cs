using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BatchCompiler.Gui.ViewModels;
using BatchCompiler.Services;

namespace BatchCompiler.Gui.Views;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        
        IProfileService profileService = new ProfileService();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new ProfileSelectWindow();
            desktop.MainWindow.DataContext = new ProfileSelectViewModel(profileService);
        }

        base.OnFrameworkInitializationCompleted();
    }
}