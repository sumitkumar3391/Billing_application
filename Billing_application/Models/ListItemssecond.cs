using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_application.Models
{
    public class ListItemssecond : INotifyPropertyChanged
    {
        private string _itemname;
        private int _itemprice;
        private int _discount;
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
        public int ItemPrice
        {
            get
            {
                return _itemprice;
            }
            set
            {
                _itemprice = value;
                OnPropertyChanged("ItemPrice");

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
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
