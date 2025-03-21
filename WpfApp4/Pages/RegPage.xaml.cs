﻿using System;
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
using WpfApp4.Functions;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Interaction logic for RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string fio = tbFIO.Text.Trim();
            string phone = tbPhone.Text.Trim();
            string pass = tbPass.Text.Trim();
            if (tbFIO != null && tbPass != null)
            {
                Registration.RegistrationSotr(fio, phone, pass);
                System.Windows.MessageBox.Show("Регистрация прошла успешно");
                NavigationService.Navigate(new AuthorisPage());
            }
            else 
            {
                MessageBox.Show("Укажате ФИО и пароль");
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }
    }
}
