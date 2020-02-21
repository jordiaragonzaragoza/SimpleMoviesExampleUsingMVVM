using System.Windows.Input;

namespace SimpleMoviesExampleUsingMVVM.Base.Commands
{
    public interface IRelayCommand : ICommand
    {
        void RaiseCanExecuteChanged();
    }
}