using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Navigators.Services;
using WPF_Navigators.Stores;
using WPF_Navigators.ViewModels;

namespace WPF_Navigators.Commands
{

    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;

        public NavigateCommand(NavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }



        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
            //_navigationStore.CurrentViewModel = _createViewModel();
        }


    }
}
