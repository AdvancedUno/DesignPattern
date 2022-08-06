using MultipleMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MultipleMVVM.Commands
{
    internal class Command : ICommand
    {

        UnoViewModel unoViewModel;
        public Command(UnoViewModel src)
        {
            this.unoViewModel = src;
        }



        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return String.IsNullOrWhiteSpace(unoViewModel.Error);
        }

        public void Execute(object parameter)
        {
            unoViewModel.ShowOutputCommand();
        }
    }
}
