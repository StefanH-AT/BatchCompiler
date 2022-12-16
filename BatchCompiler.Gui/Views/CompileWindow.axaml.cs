using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace BatchCompiler.Gui.Views;

public class CompileWindow : Window
{
    public CompileWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}