using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace avergara.Fringe.Presentation.WPF.Common
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly Action<object> executeMethod; 
        private readonly Predicate<object> canExecuteMethod;

        public Command(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            this.executeMethod = executeMethod;
            this.canExecuteMethod = canExecuteMethod;
        }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            executeMethod(parameter);
        }
    }
}
