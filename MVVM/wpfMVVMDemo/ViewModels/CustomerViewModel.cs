using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using wpfMVVMDemo.Commands;
using wpfMVVMDemo.Models;
using wpfMVVMDemo.Views;

namespace wpfMVVMDemo.ViewModels
{
    internal class CustomerViewModel
    {
        private Customer customer;
        private CustomerInfoViewModel childViewModel;
        public CustomerViewModel()
        {
            customer = new Customer("Uno");
            childViewModel = new CustomerInfoViewModel() ;
            UpdateCommand = new CustomerUpdateCommand(this);
        }

        //public bool CanUpdate
        //{
        //    get {
        //        if(Customer == null)
        //        {
        //            return false;
        //        }
        //        return !String.IsNullOrWhiteSpace(Customer.Name);
        //    }
            
        //}

        
        
        public Customer Customer
        {
            get
            {
                return customer;
            }
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        } 

        public void SaveChanges()
        {


            //Debug.Assert(false, String.Format("{0} was updated", Customer.Name));
            CustomerInfoView view = new CustomerInfoView();
            view.DataContext = childViewModel;

            //childViewModel.Info = Customer.Name + " was Updated in the DB";

            view.ShowDialog();
            

        }


    }
}
