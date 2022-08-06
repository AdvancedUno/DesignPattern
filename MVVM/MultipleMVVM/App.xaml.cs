using MultipleMVVM.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MultipleMVVM
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public static string[] Args;
        private void Application_Startup(object sender, StartupEventArgs e)
        {


            if (e.Args.Length > 0)
            {
                Args = e.Args;

            }






            Task.Factory.StartNew(() =>
            {
                ////simulate some work being done
                //for (int i = 1; i <= 100; i++)
                //{
                //    //simulate a part of work being done
                //    System.Threading.Thread.Sleep(300);

                //    //because we're not on the UI thread, we need to use the Dispatcher
                //    //associated with the splash screen to update the progress bar
                //    splashScreen.Dispatcher.Invoke(() => splashScreen.Progress = i);
                //}

                //since we're not on the UI thread
                //once we're done we need to use the Dispatcher
                //to create and show the main window
                this.Dispatcher.Invoke(() =>
                {
                    //initialize the main window, set it as the application main window
                    //and close the splash screen
                    var mainWindow = new MainWindow();
                    this.MainWindow = mainWindow;
                    mainWindow.Show();



                });
            });

            //var mainWindow = new MainWindow();
            //mainWindow.Show();
        }
    }
}
