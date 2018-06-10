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

namespace Test
{
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private string logins = "Harry Larry Cherry";
        private string passwords = "1 2 3";

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (logins.Contains(login.Text) && passwords.Contains(password.Password))
            {
                WindowOfAdmin woa = new WindowOfAdmin();
                woa.Show();
            }
            else
            {
                MessageBox.Show("Некорректно введён логин или пароль!");
            }
        }
    }
}
