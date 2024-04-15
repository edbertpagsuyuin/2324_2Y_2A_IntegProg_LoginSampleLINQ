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

namespace _2324_2Y_2A_IntegProg_LoginSampleLINQ
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1(string uname)
        {
            InitializeComponent();
            LblMessage.Content = $"Welcome Back {uname}!";
            lblname.Visibility = Visibility.Hidden;
            NewName.Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void ChangeName_Click(object sender, RoutedEventArgs e)
        {
            lblname.Visibility = Visibility.Visible;
            NewName.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
            confirm.Visibility = Visibility.Visible;
            confirm.IsEnabled = false;
            ChangeName.Visibility = Visibility.Hidden;
            NewUser.Visibility = Visibility.Hidden;
            NewName.Text = "";
        }

        private void NewName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(NewName.Text.Length > 0)
            {
                confirm.IsEnabled = true;
            }

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            ChangeName.Visibility = Visibility.Visible;
            NewUser.Visibility = Visibility.Visible;
            lblname.Visibility = Visibility.Hidden;
            NewName.Visibility = Visibility.Hidden;
            back.Visibility = Visibility.Hidden;
            confirm.Visibility = Visibility.Hidden;
        }
    }
}
