using ClassLibrary2;  

namespace ClassLibrary1
{
    public class FilmRepository : IFilmIRepository
    {
        List<Film> Films;
        public FilmRepository()
        {
            Films = new List<Film>
        {
            new Film {Id=1, Name = "Margarita", Author = "Tequila, lime juice, triple sec", Style = "A classic tequila cocktail" , Description ="4123412"},
            new Film {Id=2, Name = "Manhattan", Author = "Whiskey, sweet vermouth, bitters", Style = "A classic whiskey cocktail", Description ="4123412" },
            new Film {Id=3, Name = "Gin and Tonic", Author = "Gin, tonic water, lime", Style = "A refreshing gin cocktail", Description ="4123412" }
        };
        } 
        public void AddFilm(Film f)
        {
            f.Id = Films.Max(x => x.Id) + 1;
            Films.Add(f);
        }

        public void DeleteFilm(int id)
        {
            var f = Films.FirstOrDefault(x => x.Id == id);
            if (f != null)
                Films.Remove(f);
        }

        public List<Film> GetAllFilm()
        {
            return Films;
        }

        public Film GetFilmById(int id)
        {
            return Films.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateFilm(Film f)
        {
            var existingFilm = Films.FirstOrDefault(x => x.Id == f.Id);
            if (existingFilm != null)
            {
                f.Name = existingFilm.Name;
                f.Author = existingFilm.Author;
                f.Style = existingFilm.Style;
                f.Description= existingFilm.Description; 
            }
        } 
    }
}
