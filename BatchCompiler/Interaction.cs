namespace BatchCompiler;

public class Interaction<TIn, TOut>
{
    private Func<TIn, TOut> _func;

    public TOut Run(TIn input)
    {
        return _func(input);
    }
    
    public void RegisterHandler(Func<TIn, TOut> func)
    {
        _func = func;
    }
}

public class ParameterlessInteraction<TOut>
{
    private Func<TOut> _func;

    public TOut Run()
    {
        return _func();
    }
    
    public void RegisterHandler(Func<TOut> func)
    {
        _func = func;
    }
}