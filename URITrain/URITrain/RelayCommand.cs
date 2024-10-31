using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace URITrain
{
    public class RelayCommand : ICommand
    {

        public Action<object> execute;
        Func<object , bool> canExecute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand() { }

        public RelayCommand(Action<object> _execute, Func<object, bool> _canExecute = null)
        {
            execute = _execute;
            canExecute = _canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }

    }
}
