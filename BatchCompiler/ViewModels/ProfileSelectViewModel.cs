using System.Collections.ObjectModel;
using System.Reactive;
using BatchCompiler.Model;
using CommunityToolkit.Mvvm.Input;

namespace BatchCompiler.ViewModels;

public partial class ProfileSelectViewModel : ViewModel
{
    public ObservableCollection<Profile> Profiles { get; set; }

    public IRelayCommand AddProfile { get; }
    public IRelayCommand NewProfile { get; }
    
    public ParameterlessInteraction< Profile?> BrowseProfile { get; set; }

    public ProfileSelectViewModel()
    {
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

}