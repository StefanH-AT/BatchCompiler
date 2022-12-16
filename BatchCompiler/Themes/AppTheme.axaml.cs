using Avalonia.Markup.Xaml;

namespace BatchCompiler.Themes;

public class AppTheme : Avalonia.Styling.Styles
{
    public AppTheme() => AvaloniaXamlLoader.Load(this);
}