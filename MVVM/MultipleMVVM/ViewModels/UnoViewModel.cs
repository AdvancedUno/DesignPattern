using MultipleMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Windows.Input;
using MultipleMVVM.Commands;

namespace MultipleMVVM.ViewModels
{
    public partial class UnoViewModel : INotifyPropertyChanged
    {
        private UnoModel person;

        private BitmapImage showImage;
        


        private String outputTxt;


        public UnoViewModel()
        {
            person = new UnoModel("Uno");
            UpdateCommand = new Command(this);
        }


        public UnoModel Person
        {
            get
            {
                return person;
            }
        }

        public String OutputTxt
        {
            get
            {
                return outputTxt;
            }
            set
            {
                outputTxt = value;
                OnPropertyChanged("OutputTxt");
            }
        }

        public BitmapImage ShowImage
        {
            get { return showImage; }
            set {
                showImage = value;
                OnPropertyChanged("ShowImage");
            }
        }

        
        public void ShowOutputCommand()
        {
            OutputTxt = String.Format("{0} --> {1}", person.Name, person.CommandAction);
            ExecuteCmdAction(person.CommandAction);
        }


        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        private void ExecuteCmdAction(string cmdInfo)
        {
            if (cmdInfo == "Run")
            {
                ShowImage = person.RunImage;
            }
            else if (cmdInfo == "Jump")
            {
                ShowImage = person.JumpImage;
            }
            else
            {
                ShowImage = person.StandImage;
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

        public string Error
        {
            get;
            private set;

        }
        public string this[string columName]
        {
            get
            {
                if (columName == "Name")
                {
                    if (String.IsNullOrWhiteSpace(person.Name))
                    {
                        Error = "Name cannot be null or empty";
                    }
                    else
                    {
                        Error = null;
                    }
                }
                return Error;
            }
        }
    }
}
