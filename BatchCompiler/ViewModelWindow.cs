using Avalonia.Controls;

namespace BatchCompiler;

public abstract class ViewModelWindow<T> : Window where T : ViewModel
{
    protected T ViewModel
    {
        get
        {
            var vm = DataContext as T;
            if (vm is null) 
                throw new ViewModelMismatchException();
            return vm;
        }
    }
    
}