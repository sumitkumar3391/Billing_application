using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billing_application.Models;

namespace Billing_application.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CustomerDetail> _customers;



        public ObservableCollection<CustomerDetail> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }
        public CustomerViewModel()
        {
            _customers = new ObservableCollection<CustomerDetail>();
        }
        public void add1(CustomerDetail newCustomer)
        {
            _customers.Add(newCustomer);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
