using System.Collections.Generic;
using System.Threading.Tasks;
using BatchCompiler.Model;
using BatchCompiler.Services;

namespace BatchCompiler.Gui.DummyServices;

public class DummyProfileService : IProfileService
{
    public Task<List<Profile>> LoadProfilesAsync()
    {
        return Task.FromResult(new List<Profile>()
        {
            new Profile()
            {
                Name = "CS:GO", 
                MapSourceDirectory = "C:/Program Files (x86)/Steam/steamapps/common/Counter-Strike Global Offensive/sdk_content/maps",
                MapDestinationDirectory = "C:/Program Files (x86)/Steam/steamapps/common/Counter-Strike Global Offensive/csgo/maps",
                Maps = new List<Map>()
                {
                    new Map("de_dust2"),
                    new Map("de_mirage"),
                    new Map("de_inferno"),
                    new Map("de_nuke"),
                },
                CompileSteps = new List<CompileStep>()
                {
                    
                }
            }
        });
    }

    public Task SaveProfileAsync(Profile profile)
    {
        return Task.Delay(2000);
    }
}