using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BatchCompiler.ViewModels;

namespace BatchCompiler.Views;

public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new ProfileSelectWindow();
            desktop.MainWindow.DataContext = new ProfileSelectViewModel();
        }

        base.OnFrameworkInitializationCompleted();
    }
}