using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_application.Models
{
 public class ListItems : INotifyPropertyChanged
    {
        private string _itemname;
        private int _price;
        private int _discount;
        private int _quantity;
        

        public string ItemName
        {
            get
            {
                return _itemname;
            }
            set
            {
                _itemname = value;
                OnPropertyChanged("ItemName");
            }
        }
        public int Price
        {
            get
            {
                return _price;    
            }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        public int Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
                OnPropertyChanged("Discount");
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
