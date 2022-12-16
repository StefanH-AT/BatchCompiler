
namespace BatchCompiler.Model;

public record Profile
{
    public string Name { get; set; } = string.Empty;
    public List<CompileStep> CompileSteps { get; init; } = new();
    public List<Map> Maps { get; init; } = new();
    public string MapSourceDirectory { get; init; } = string.Empty;
    public string MapDestinationDirectory { get; init; } = string.Empty;
}