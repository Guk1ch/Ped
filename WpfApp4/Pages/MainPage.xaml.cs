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
using System.Collections.ObjectModel;
using WpfApp4.Data;
using WpfApp4.Functions;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public static ObservableCollection<Film> filmList { get; set; } 
        public MainPage()
        {
            InitializeComponent();
            filmList = FilmFunctions.GetFilms();
            this.DataContext = this;
        }

        private void esc_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }

        private void LvMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void tbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            filmList = FilmFunctions.GetFilms();
            if (tbSearch.Text != "") 
            {
                filmList = FilmFunctions.SearchFilm(tbSearch.Text.Trim());
            }
            if (filmList.Count == 0)
            {
                MessageBox.Show("Ничего не найдено");
            }
            else 
            {
                
            }
            LvMain.ItemsSource = filmList;
        }
    }
}
