using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Navigators.Stores;
using WPF_Navigators.ViewModels;

namespace WPF_Navigators
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Navigation navigationStore = new Navigation();

            navigationStore.CurrentViewModel = new AccountViewModel(navigationStore);

            MainWindow = new MainWindow() {
                DataContext = new MainViewModel(navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

    }
}
