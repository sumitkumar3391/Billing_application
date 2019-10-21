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
    class ItemsViewModel : INotifyPropertyChanged
    {
        

        private ObservableCollection<ListItems> _listitems;


        public ObservableCollection<ListItems> ListItems
        {
            get
            {
                return _listitems;
            }
            set
            {
                _listitems = value;
                OnPropertyChanged("ListItems");
            }
        }

        public ItemsViewModel()
        {
            _listitems = new ObservableCollection<ListItems>();
        }

        public void addItems(ListItems listItems)
        {
            _listitems.Add(listItems);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
