using BatchCompiler.Model;

namespace BatchCompiler.Services;

public interface IProfileService
{
    Task<List<Profile>> LoadProfilesAsync();
    Task SaveProfileAsync(Profile profile);
}