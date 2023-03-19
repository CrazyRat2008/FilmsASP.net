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
            new Film { Name = "Margarita", Author = "Tequila, lime juice, triple sec", Style = "A classic tequila cocktail" , Description ="4123412"},
            new Film { Name = "Manhattan", Author = "Whiskey, sweet vermouth, bitters", Style = "A classic whiskey cocktail", Description ="4123412" },
            new Film { Name = "Gin and Tonic", Author = "Gin, tonic water, lime", Style = "A refreshing gin cocktail", Description ="4123412" }
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
            //var existingBook = Films.FirstOrDefault(x => x.Id == f.Id);
            //if (existingBook != null)
            //{
            //    f.Title = existingBook.Title;
            //    f.Author = existingBook.Author;
            //    book.Genre = existingBook.Genre;
            //    book.Publisher = existingBook.Publisher;
            //    book.YearOfPublishing = existingBook.YearOfPublishing;


            //}
        } 
    }
}
