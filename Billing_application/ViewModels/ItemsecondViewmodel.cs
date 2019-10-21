using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billing_application.ViewModels
{
     public class ItemsecondViewmodel
    {
        private ObservableCollection<Models.ListItemssecond> _listitems;

        public ObservableCollection<Models.ListItemssecond> listItems
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

        public ItemsecondViewmodel()
        {
            _listitems = new ObservableCollection<Models.ListItemssecond>();
        }

        public void additems(Models.ListItemssecond listItemssecond)
        {
            _listitems.Add(listItemssecond);
        }

    }
}
