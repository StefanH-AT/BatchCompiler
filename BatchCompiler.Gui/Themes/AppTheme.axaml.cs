using Avalonia.Markup.Xaml;

namespace BatchCompiler.Gui.Themes;

public class AppTheme : Avalonia.Styling.Styles
{
    public AppTheme() => AvaloniaXamlLoader.Load(this);
}