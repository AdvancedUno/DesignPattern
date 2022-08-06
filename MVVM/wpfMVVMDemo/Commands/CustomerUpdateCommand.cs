using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfMVVMDemo.ViewModels;

namespace wpfMVVMDemo.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        private CustomerViewModel viewModel;
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            //return _ViewModel.CanUpdate;
            return String.IsNullOrWhiteSpace(viewModel.Customer.Error);
        }

        public void Execute(object parameter)
        {
            viewModel.SaveChanges();
        }
    }
}
