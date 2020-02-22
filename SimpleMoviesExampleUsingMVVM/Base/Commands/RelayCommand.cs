using System;

namespace SimpleMoviesExampleUsingMVVM.Base.Commands
{
    /// <summary>
    /// Parameter less RelayCommand
    /// Please use this class if you want to follow MVVM.
    /// </summary>
    public class RelayCommand : IRelayCommand
    {
        #region Fields
        
        /// <summary>
        /// Execute Action.
        /// </summary>
        private readonly Action _execute;

        /// <summary>
        /// CanExecute Predicate.
        /// </summary>
        private readonly Func<bool> _canExecute;

        #endregion Fields

        #region Constructors

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion Constructors

        #region ICommand Members

        /// <summary>
        /// Can execute logic.
        /// </summary>
        /// <param name="parameter">can execute Parameter.</param>
        public bool CanExecute(object parameter)
        {
            return null == _canExecute ? true : _canExecute();
        }

        /// <summary>
        /// Execute.
        /// </summary>
        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            if (null != CanExecuteChanged)
            {
                CanExecuteChanged.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion ICommand Members
    }
}