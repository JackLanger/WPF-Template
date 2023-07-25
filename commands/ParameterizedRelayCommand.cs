using System;
using System.Windows.Input;

namespace Visualizer.commands;

public class ParameterizedRelayCommand<T> : ICommand
{
    private Action<T?> _action;

    public ParameterizedRelayCommand(Action<T?> action)
    {
        this._action = action;
    }
    
    
    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter) => _action.Invoke((T?)parameter);

    public event EventHandler? CanExecuteChanged;
}