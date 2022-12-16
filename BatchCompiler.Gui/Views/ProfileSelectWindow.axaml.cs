using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BatchCompiler.Gui.ViewModels;
using BatchCompiler.Model;

namespace BatchCompiler.Gui.Views;

public partial class ProfileSelectWindow : ViewModelWindow<ProfileSelectViewModel>
{
    public ProfileSelectWindow()
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

    protected override void OnDataContextChanged(EventArgs e)
    {
        ViewModel.BrowseProfile.RegisterHandler(BrowseProfile);
    }

    public Profile? BrowseProfile()
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Title = "Select a profile";
        dialog.Filters = new List<FileDialogFilter> { new() {Name = "Profile", Extensions = new List<string> {"bc_profile"}} };
        dialog.AllowMultiple = false;
        string[]? result = dialog.ShowAsync(this).Result;
        
        if (result is null || result.Length != 1) return null;

        string path = result[0];

        Profile? profile = JsonSerializer.Deserialize<Profile>(File.ReadAllText(path));
        if (profile is null)
        {
            Console.WriteLine("Profile couldn't be loaded");
            return null;
        }

        return profile;
    }
}