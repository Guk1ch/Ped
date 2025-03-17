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
using WpfApp4.Functions;
using WpfApp4.Data;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorisPage.xaml
    /// </summary>
    public partial class AuthorisPage : Page
    {
        public static Sotrudnik sotrudnik;
        public AuthorisPage()
        {
            InitializeComponent();
        }

        private void BtnAuthoriz_Click(object sender, RoutedEventArgs e)
        {
            int login = Convert.ToInt32(TbLogin.Text.Trim());
            string password = TbPassword.Password.Trim();
            sotrudnik = Authorisation.AuthorisationSotr(login, password);
            if(sotrudnik != null)
            {
                //NavigationService.Navigate();
                MessageBox.Show("Ура в меня вошли");
            }
            else
            {
                MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            //ddghhk
        }
    }
}
