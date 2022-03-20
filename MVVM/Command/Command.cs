using System;
using System.Windows.Input;

namespace MVVM.Command
{
    /// <summary>
    /// Base implement of <see cref="ICommand"/>
    /// </summary>
    public class Command : ICommand
    {
        #region ctor

        public Command(Action<object> action, Predicate<object> canExecute = null)
        {
            ExecuteDelegate = action;
            CanExecuteDelegate = canExecute;
        }

        #endregion

        #region Props

        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action<object> ExecuteDelegate { get; set; }

        #endregion

        #region ICommand методы

        public bool CanExecute(object parameter) => CanExecuteDelegate == null || CanExecuteDelegate(parameter);


        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void Execute(object parameter) => ExecuteDelegate?.Invoke(parameter);

        #endregion
    }
}

