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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Billing_application.ViewModels;
using System.Windows.Forms;



namespace Billing_application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private MainViewModel _mainviewmodel;
        public MainWindow()
        {

            InitializeComponent();
            _mainviewmodel = new MainViewModel();
            this.DataContext = _mainviewmodel;
            

        }




       

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox2.Text, "[^0-9]"))
            {
                System.Windows.MessageBox.Show("please enter numbers only ");
                e.Handled = true;
            }

            if (txtbox2.Text.Length >= 2 || e.Key == Key.Enter)
            {
                var tuple =  _mainviewmodel.addlist(Int32.Parse(txtblock1.Text), Int32.Parse(txtblock2.Text), combo1.Text);
                txtquantity.Text = Convert.ToString(tuple.Item3);
                txtdiscount.Text = Convert.ToString(tuple.Item2);
                txtsubtotal.Text = Convert.ToString(tuple.Item1);
                int calculated_discount = Convert.ToInt32(Convert.ToInt16(txtsubtotal.Text) * Convert.ToInt16(txtdiscount.Text) / 100);
                int total =Convert.ToInt16(txtsubtotal.Text) - calculated_discount;
                if(total > 1000)
                {
                    txttotal.Background = new SolidColorBrush(Colors.GreenYellow);
                    int extra_discount = Convert.ToInt32(total - total * 10 / 100);
                    txttotal.Text = Convert.ToString(extra_discount) + "(extra 10% discount)";
                }
                else
                {
                    txttotal.Background = new SolidColorBrush(Colors.Green);
                    txttotal.Text = Convert.ToString(total);
                }
                

                
            }
                          
            

        }



        private void Txtbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtbox1.MaxLength = 9;
            txtbox1.Focus();
        }

        private void Txtbox1_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            txtbox1.MaxLength = 9;

            if (System.Text.RegularExpressions.Regex.IsMatch(txtbox1.Text, "[^0-9]"))
            {
                System.Windows.MessageBox.Show("please enter numbers only ");
                e.Handled = true;
            }
            if (txtbox1.Text.Length == 9)
            {
                string result = string.Empty;
                result = _mainviewmodel.addcommand();


                label1.Content = result;


            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window1();
            window.Show();


        }
        //private void addItem(string text)
        //{
        //    TextBlock block = new TextBlock();
        //    block.Text = text;
        //    block.Margin = new Thickness(2, 3, 2, 3);
        //    block.Cursor = System.Windows.Input.Cursors.Hand;
        //    block.MouseLeftButtonUp += (sender, e) =>
        //    {
        //        textbox.Text = (sender as TextBlock).Text;
        //        TextBlock b = sender as TextBlock;


        //    };
        //    block.MouseEnter += (sender, e) =>
        //    {
        //        TextBlock b = sender as TextBlock;
        //        b.Background = Brushes.PeachPuff;
        //    };

        //    block.MouseLeave += (sender, e) =>
        //    {
        //        TextBlock b = sender as TextBlock;
        //        b.Background = Brushes.Transparent;
        //    };


        //    // Add to the panel   
        //    resultstack.Children.Add(block);


        //}

        //private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        //{
        //    bool found = false;
        //    var border = (resultstack.Parent as ScrollViewer).Parent as Border;
        //    var data = ViewModels.MainViewModel.Getdata();

        //    string query = (sender as System.Windows.Controls.TextBox).Text;

        //    if(query.Length == 0)
        //    {
        //        resultstack.Children.Clear();
        //        border.Visibility = System.Windows.Visibility.Collapsed;

        //    }
        //    else
        //    {
        //        border.Visibility = System.Windows.Visibility.Visible;
        //    }
        //    resultstack.Children.Clear();

        //    foreach(var obj in data)
        //    {
        //        if (obj.ToLower().StartsWith(query.ToLower()))
        //        {
        //            addItem(obj);
        //            found = true;


        //        }

        //    }


        //    if (!found)
        //    {
        //        resultstack.Children.Add(new TextBlock()
        //        {
        //            Text = "no result found"
        //        });
        //    }

        //}

        //private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    System.Windows.Forms.TextBox t = sender as System.Windows.Forms.TextBox;
        //    if(t != null)
        //    {
        //        if(t.Text.Length >= 3)
        //        {
        //            string[] arr = MainViewModel.Getdata();
        //            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
        //            collection.AddRange(arr);
        //            this.textbox.auto
        //        }
        //    }
        //}
    }
}

