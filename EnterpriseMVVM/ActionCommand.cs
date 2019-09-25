using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EnterpriseMVVM
{
    class ActionCommand : ICommand
    {
        private readonly Action<Object> action;
        private readonly Predicate<Object> predicate;


        public ActionCommand(Action<Object> action) : this(action, null)
        {
            this.action = action;
        }

        public ActionCommand(Action<Object> action, Predicate<Object> predicate)
        {
            if (action == null)
            {
                throw new ArgumentNullException("You must specify an Action<T>");
            }

            this.action = action;
            this.predicate = predicate;

        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }

        }

        public bool CanExecute(object parameter)
        {
            if (predicate == null)
            {
                return true;
            }
            return predicate(parameter);
        }

        public void Execute()
        {
            Execute(null);
        }

        public void Execute(object parameter)
        {
            action(parameter);
        }
    }
}
