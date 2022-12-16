using System.Collections.ObjectModel;
using Avalonia.Controls;
using BatchCompiler.Gui.DummyServices;
using BatchCompiler.Model;
using BatchCompiler.Services;
using CommunityToolkit.Mvvm.Input;

namespace BatchCompiler.Gui.ViewModels;

public partial class ProfileSelectViewModel : ViewModel
{
    private readonly IProfileService _profileService;
    
    public ObservableCollection<Profile> Profiles { get; set; }

    public IRelayCommand AddProfile { get; }
    public IRelayCommand NewProfile { get; }
    
    public ParameterlessInteraction< Profile?> BrowseProfile { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="profileService"></param>
    public ProfileSelectViewModel(IProfileService profileService)
    {
        _profileService = profileService;
        Profiles = new ObservableCollection<Profile>();
        BrowseProfile = new ParameterlessInteraction<Profile?>();
        
        AddProfile = new RelayCommand(() =>
        {
            var profile = BrowseProfile.Run();
            if (profile is not null)
            {
                Profiles.Add(profile);
            }
        });
        
        NewProfile = new RelayCommand(() =>
        {
            var profile = new Profile();
            Profiles.Add(profile);
        });
    }

    /// <summary>
    /// Design-time constructor
    /// </summary>
    public ProfileSelectViewModel() : this(new DummyProfileService())
    {
        if (Design.IsDesignMode)
            throw new InvalidOperationException("This constructor should only be called in design mode");
    }

}