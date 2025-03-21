using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp4.Data;

namespace WpfApp4.Functions
{
    public class FilmFunctions
    {
        public static ObservableCollection<Film> films { get; set; }

        //Получение списка фильмов
        public static ObservableCollection<Film> GetFilms()
        {
            return new ObservableCollection<Film>(DB_Class.connection.Film.ToList());
        }

        // функция поиска фильма 
        public static Film GetFilmInfo(int id)
        {
            Film selectedFilm = DB_Class.connection.Film.Where(filmId => filmId.Id == id).FirstOrDefault();
            Film film = new Film
            {
                Id = selectedFilm.Id,
                Name = selectedFilm.Name,
                id_vozr_ogranich = selectedFilm.id_vozr_ogranich,
                cost_arend = selectedFilm.cost_arend
            };
            return film;
        }

    }
}
