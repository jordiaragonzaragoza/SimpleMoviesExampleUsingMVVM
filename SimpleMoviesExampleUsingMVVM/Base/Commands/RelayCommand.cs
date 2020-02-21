using System;

namespace SimpleMoviesExampleUsingMVVM.Base.Commands
{
    public class RelayCommand : IRelayCommand
    {
        #region Fields

        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        #endregion Fields

        #region Constructors

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion Constructors

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return null == _canExecute ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public void RaiseCanExecuteChanged()
        {
            if (null != this.CanExecuteChanged)
                this.CanExecuteChanged.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        #endregion ICommand Members
    }
}