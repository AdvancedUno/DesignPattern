using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Navigators.Services;
using WPF_Navigators.Stores;
using WPF_Navigators.ViewModels;

namespace WPF_Navigators.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly LoginViewModel _viewModel;
        private readonly NavigationService<AccountViewModel> _navigationService;

        public LoginCommand(LoginViewModel viewModel, NavigationService<AccountViewModel> navigationService)
        {
            _viewModel = viewModel;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            MessageBox.Show($"Logging in {_viewModel.Username} ...");

            _navigationService.Navigate();

        }
        
    }
}
