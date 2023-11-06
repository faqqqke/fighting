using fighting.DataApp;
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

namespace fighting.Pages
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ButtonHomePagePlay_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxHomePageUserName.Text != null || TextBoxHomePageUserName.Text != "Username")
                PageClass.FrameMain.Navigate(new PlayPage());
            else
                MessageBox.Show("vvedeno neverno");
            //после привязки бд поменять
        }


        private void TextBoxHomePageUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxHomePageUserName.Text = string.Empty;
        }

        private void ButtonHomePageRules_Click(object sender, RoutedEventArgs e)
        {
            PageClass.FrameMain.Navigate(new RulesPage());
        }
    }
}
