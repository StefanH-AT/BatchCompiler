using System.CommandLine;
using System.CommandLine.Invocation;
using BatchCompiler.Model;

namespace BatchCompiler.Cli;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var profileOption = new Option<FileInfo?>("--profile", "Path to the profile file to use");
        var completionActionOption = new Option<CompletionActionType>("--completion-action", "Action to take when all processes complete");
        var threadsOption = new Option<int>("--threads", "Number of threads to use");

        var rootCommand = new RootCommand("Batch compilation tool for source engine maps");
        rootCommand.AddOption(profileOption);
        rootCommand.AddOption(completionActionOption);
        rootCommand.AddOption(threadsOption);

        rootCommand.SetHandler(HandleCommand);

        return await rootCommand.InvokeAsync(args);
    }

    private static void HandleCommand(InvocationContext obj)
    {
        throw new NotImplementedException();
    }
}

