using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Navigators.Stores;
using WPF_Navigators.ViewModels;

namespace WPF_Navigators.Services
{

    public class NavigationService<TViewModel>
        where TViewModel : ViewModelBase
    {
        private readonly Navigation _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(Navigation navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
        
    }
}
