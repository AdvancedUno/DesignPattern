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
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomeMessage => "aaaa";

        public ICommand NavigateHomeCommand { get; }
        public AccountViewModel(Navigation navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(
                new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore)));

        }
    }
}
