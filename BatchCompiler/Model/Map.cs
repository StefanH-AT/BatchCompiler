namespace BatchCompiler.Model;

public record Map
{
    public string Name => System.IO.Path.GetFileName(Path);
    public string Path { get; set; }
    public string AbsolutePath => System.IO.Path.GetFullPath(Path);

    public Map(string path)
    {
        this.Path = path;
    }
}