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
    public class LoginViewModel : ViewModelBase
    {

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));   
            }

        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(Navigation navigationStore)
        {
            LoginCommand = new LoginCommand(this, new NavigationService<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore)));
        }

    }
}
