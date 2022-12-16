using System.Collections.Generic;

namespace BatchCompiler.Model;

public enum CompletionActionType
{
    None,
    Close,
    Shutdown,
    Sleep
}

public record CompletionAction
{
    public static CompletionAction None { get; } = new CompletionAction(CompletionActionType.None);
    public static CompletionAction Close { get; } = new CompletionAction(CompletionActionType.Close);
    public static CompletionAction Shutdown { get; } = new CompletionAction(CompletionActionType.Shutdown);
    public static CompletionAction Sleep { get; } = new CompletionAction(CompletionActionType.Sleep);
    
    public static IEnumerable<CompletionAction> All { get; } = new[]
    {
        None,
        Close,
        Shutdown,
        Sleep
    };

    private CompletionAction(CompletionActionType type)
    {
        Type = type;
    }
    public CompletionActionType Type;
    public string Label => Type switch
    {
        CompletionActionType.None => "Do Nothing",
        CompletionActionType.Close => "Close",
        CompletionActionType.Shutdown => "Shutdown Computer",
        CompletionActionType.Sleep => "Sleep Computer",
        _ => throw new ArgumentOutOfRangeException(nameof(Type), Type, null)
    };
}