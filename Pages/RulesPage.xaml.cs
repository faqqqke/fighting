﻿using fighting.DataApp;
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
    /// Логика взаимодействия для RulesPage.xaml
    /// </summary>
    public partial class RulesPage : Page
    {
        public RulesPage()
        {
            InitializeComponent();
        }

        private void ButtonRulesPageOK_Click(object sender, RoutedEventArgs e)
        {
            PageClass.FrameMain.GoBack();
        }
    }
}
