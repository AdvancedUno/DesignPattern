using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace wpfMVVMDemo.Models
{
    public class Customer : INotifyPropertyChanged, IDataErrorInfo
    {
        private string name;

        /// <summary>
        /// Init a ne winstnace of the customer Class;
        /// </summary>
        public Customer(String customerName)
        {
            Name = customerName;
        }

        

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            } 
        }

     

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            
            if(handler != null)
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
                    if (String.IsNullOrWhiteSpace(Name))
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
