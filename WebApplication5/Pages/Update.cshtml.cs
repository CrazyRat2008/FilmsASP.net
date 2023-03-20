using ClassLibrary2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication5.Pages
{
    public class UpdateModel : PageModel
    {


        [BindProperty]
        public Film film { get; set; }
        private readonly IFilmIRepository filmRep;
        public UpdateModel(IFilmIRepository bookRepository)
        {
            filmRep = bookRepository;
        }
        public void OnGet(int id)
        {
            film = filmRep.GetFilmById(id);
        }

        [HttpPost]
        public void OnPost()
        {
            if (film.Name != null)
                filmRep.UpdateFilm(film);

        }

    }
}
