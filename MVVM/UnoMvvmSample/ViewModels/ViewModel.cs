using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnoMvvmSample.Models;

namespace UnoMvvmSample.ViewModels
{
    public partial class ViewModel : INotifyPropertyChanged
	{
        private Model hello;

		private String outTxt;
        public ViewModel()
        {
            hello = new Model();
        }

        public String OutTxt
        {
            get
            {
                return outTxt;
            }
            set
            {
				outTxt = value;
				OnPropertyChanged("OutTxt");
			}
        }

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}


		private ICommand showCommand;
        public ICommand ShowCommnad
        {
            get { return (this.showCommand) ?? (this.showCommand = new DelegateCommand(Show)); }
        }

        private void Show()
        {

			OutTxt = hello.OutputTxt;


		}

    }

	public class DelegateCommand : ICommand
	{
		private readonly Func<bool> canExecute;
		private readonly Action execute;

		public DelegateCommand(Action exectue) : this(exectue, null)
		{
		}

		public DelegateCommand(Action execute, Func<bool> canExecute)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged;
		public bool CanExecute(object parameter)
		{
			if (this.canExecute == null)
			{
				return true;
			}
			return this.canExecute();
		}

		public void Execute(object parameter)
		{
			this.execute();
		}

		public void RaiseCanExecuteChanged()
		{
			if (this.CanExecuteChanged != null)
			{
				this.CanExecuteChanged(this, EventArgs.Empty);
			}
		}

	}
}
