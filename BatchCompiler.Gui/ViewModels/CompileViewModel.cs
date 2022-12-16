using System.Collections.Generic;
using BatchCompiler.Model;

namespace BatchCompiler.Gui.ViewModels;

public class CompileViewModel
{
    public IEnumerable<CompletionAction> AvailableCompletionActions => CompletionAction.All;
    public CompletionAction CompletionAction { get; set; } = CompletionAction.None;
    public Profile Profile { get; set; }
    
    public void NewProfile()
    {
        Profile = new Profile();
    }
}