using MySqlX.XDevAPI.Relational;
using System;
using System.CodeDom;
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

namespace PasswordManager
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {


        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string loginField = logField.Text;
            string passwordField = logField.Text;

        }

        private void ClearFieldButton_Click(object sender, RoutedEventArgs e)
        {
            
            logField.Clear();
            passField.Clear();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CopyPassword_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(searchPassField.Password.ToString());
        }

        private void SearchClearButton_Click(object sender, RoutedEventArgs e)
        {
            searchLogField.Clear();
            searchPassField.Clear();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
