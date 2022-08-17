using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Navigators.ViewModels;

namespace WPF_Navigators.Stores
{
    public class Navigation
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBase _currentViewModel;


        public ViewModelBase CurrentViewModel {

            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChaged();

            }

        }

        private void OnCurrentViewModelChaged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
