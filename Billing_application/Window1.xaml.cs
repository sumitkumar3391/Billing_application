using Billing_application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Billing_application
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainViewModel _mainviewmodel;
        public Window1()
        { 
            InitializeComponent();
            _mainviewmodel = new MainViewModel();
            this.DataContext = _mainviewmodel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _mainviewmodel.addnewCustomer();
            this.Close();
            
        }
    }
}
