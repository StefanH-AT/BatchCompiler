using System.Collections.Generic;

namespace BatchCompiler.Model;

public enum CompileStepType
{
    Bsp,
    Vis,
    Rad,
    Copy,
    Executable
}

public record CompileStep
{
    public static CompileStep Bsp => new CompileStep(CompileStepType.Bsp);
    public static CompileStep Vis => new CompileStep(CompileStepType.Vis);
    public static CompileStep Rad => new CompileStep(CompileStepType.Rad);
    public static CompileStep Copy => new CompileStep(CompileStepType.Copy);
    public static CompileStep Executable => new CompileStep(CompileStepType.Executable);

    private CompileStep(CompileStepType type)
    {
        Type = type;
    }
    
    public CompileStepType Type { get; init; }
    public string Label => Type switch
    {
        CompileStepType.Bsp => "BSP",
        CompileStepType.Vis => "VIS",
        CompileStepType.Rad => "RAD",
        CompileStepType.Copy => "Copy",
        CompileStepType.Executable => "Executable",
        _ => throw new ArgumentOutOfRangeException(nameof(Type), Type, null)
    };

    public bool Enabled { get; set; } = true;
}