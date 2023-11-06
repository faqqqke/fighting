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
    /// Логика взаимодействия для PlayPage.xaml
    /// </summary>
    public partial class PlayPage : Page
    {
        int damage;
        int block;
        public PlayPage()
        {
            InitializeComponent();
            TextBlockPlayerHP.Text = ProgressBarPlayer.Value.ToString();
            TextBlockAIHP.Text = ProgressBarAI.Value.ToString();
        }

        public void Checkalive()
        {
            if (ProgressBarAI.Value <= 0)
            {
                MessageBox.Show("Winner - Player");//поменять на ($"winner - {username}");
                PageClass.FrameMain.Navigate(new HomePage());
            }

            else if (ProgressBarPlayer.Value <= 0)
            {
                MessageBox.Show("Winner - AI");
                PageClass.FrameMain.Navigate(new HomePage());
            }
                
        }

        private void ButtonPlayerBlockBody_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPlayerBlockHead_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPlayerAttackBody_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPlayerAttackHead_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
