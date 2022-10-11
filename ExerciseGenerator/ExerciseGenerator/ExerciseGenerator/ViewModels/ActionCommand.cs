using System;
using System.Windows.Input;

namespace ExerciseGenerator.ViewModels
{
    public class ActionCommand : ICommand
    {
        private readonly Action<object> _executeHandler;
        private readonly Func<object, bool> _canExecuteHandler;

        public ActionCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            _executeHandler = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecuteHandler = canExecute;
        }

        public void Execute(object parameter) => this._executeHandler(parameter);

        public bool CanExecute(object parameter) => this._canExecuteHandler == null || this._canExecuteHandler(parameter);

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}
