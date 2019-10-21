using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_application.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    
    {
        private int _number;
        private string _firstname;
        private string _lastname;
        private int _quantity;
        private int _itemprice;
        private int _phonenumber;
        
        private CustomerViewModel _pvm;
        private ItemsViewModel _ivm;
        private ItemsecondViewmodel _isvm;
        

        
        private ObservableCollection<Models.CustomerDetail> _customers;
        private ObservableCollection<Models.ListItems> _listitems;
        private ObservableCollection<Models.ListItemssecond> _listseconditems;
        



        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                OnPropertyChanged("LastName");
            }
        }
        
        public int PhoneNumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                
                _number = value;
                OnPropertyChanged("Number");
                


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
        public int Price
        {
            get
            {
                return _itemprice;
            }
            set
            {
                _itemprice = value;
                OnPropertyChanged("Price");
            }

        }
        
        public ObservableCollection<Models.CustomerDetail> Customers
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
        public ObservableCollection<Models.ListItems> ListItems
        {
            get
            {
                return _listitems;
            }
            set
            {
                _listitems = value;
            }
        }
        public ObservableCollection<Models.ListItemssecond> ListSecondItems
        {
            get
            {
                return _listseconditems;
            }
            set
            {
                _listseconditems = value;
            }
        }
        

        

        
        public MainViewModel()
        {
            _pvm = new CustomerViewModel();
            _customers = _pvm.Customers;
            _ivm = new ItemsViewModel();
            _listitems = _ivm.ListItems;
            _isvm = new ItemsecondViewmodel();
            _listseconditems = _isvm.listItems;
            var person = new Models.CustomerDetail();
            person.FirstName = "sumit";
            person.PhoneNumber = 987813272;
            person.LastName = "sharma";
            _pvm.add1(person);
            var person1 = new Models.CustomerDetail();
            person1.FirstName = "akshay";
            person1.LastName = "kumar";
            person1.PhoneNumber = 123456789;
            _pvm.add1(person1);
            var items = new Models.ListItemssecond();
            items.ItemName = "pencil";
            items.ItemPrice = 200;
            items.Discount = 5;
            _isvm.additems(items);
            var items2 = new Models.ListItemssecond();
            items2.ItemName = "Eraser";
            items2.ItemPrice = 100;
            items2.Discount = 2;
            _isvm.additems(items2);
            
            
        }
        public string addcommand()
        {
            string result = string.Empty;
        var s = from i in _customers where i.PhoneNumber == _number select new { i.FirstName, i.LastName };
            if(!s.Any())
            {
                
                result = "Data not found";
                return result;
            }
          


           else
            {
                foreach (var j in s)
                {
                    result = j.FirstName + "  " + " " + j.LastName;
                }
                return result;
            }
            
            
           
         }
        public Tuple<double, double,double> addlist( int txtblock1 , int txtblock2, string combox )
        {
            var item = new Models.ListItems();
            item.ItemName = combox;
            item.Price = txtblock1 * _quantity;
            item.Discount = txtblock2;
            item.Quantity = _quantity;
            
            _ivm.addItems(item);
            double TotalPrice = _listitems.Sum(s => s.Price);
            double TotalDiscount = _listitems.Sum(t => t.Discount);
            double TotalQuantity = _listitems.Sum(q => q.Quantity);
            return new Tuple<double, double, double>(TotalPrice, TotalDiscount, TotalQuantity);

            
        }
        public void addnewCustomer()
        {
            

            var person1 = new Models.CustomerDetail();
            person1.FirstName = _firstname;
            person1.LastName = _lastname;
            person1.PhoneNumber = _phonenumber;
            _pvm.add1(person1);



            
            


        }
        //static public List<string> Getdata()
        //{
        //    List<string> data = new List<string>();
        //    data.Add("pencil");
        //    data.Add("eraser");
        //    data.Add("sharpner");
        //    data.Add("Colors");
        //    data.Add("pen");
        //    return data;
           
        //}
       

        

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
