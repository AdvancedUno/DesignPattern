using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_Navigators.Commands;
using WPF_Navigators.Services;
using WPF_Navigators.Stores;

namespace WPF_Navigators.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "aaaa";

        public ICommand NavigateAccountCommand { get; }


        public HomeViewModel(Navigation navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<LoginViewModel>
                (new NavigationService<LoginViewModel>( navigationStore, () => new LoginViewModel(navigationStore)));
        }

        
    }
}
