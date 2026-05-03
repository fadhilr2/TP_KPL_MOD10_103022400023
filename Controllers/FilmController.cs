using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;
using TP_MOD10_103022400023;

namespace FilmApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        private static List<Film> listFilm = new List<Film>
        {
            new Film(1, "Inception", "Christopher Nolan", 2010, "Sci-Fi", 9.0),
            new Film(2, "Interstellar", "Christopher Nolan", 2014, "Sci-Fi", 8.7),
            new Film(3, "Parasite", "Bong Joon-ho", 2019, "Thriller", 8.6)
        };

        [HttpGet]
        public ActionResult<IEnumerable<Film>> GetAll()
        {
            return Ok(listFilm);
        }

        [HttpGet("{id}")]
        public ActionResult<Film> GetByIndex([FromRoute] string id)
        {
            int idx = Int32.Parse(id)-1;
            if (idx < 0 || idx >= listFilm.Count)
                return NotFound("Film tidak ditemukan.");

            return Ok(listFilm[idx]);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Film newFilm)
        {
            listFilm.Add(newFilm);
            return Ok("Film berhasil ditambahkan.");
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] string id)
        {
            int idx = Int32.Parse(id) - 1;
            if (idx < 0 || idx >= listFilm.Count)
                return NotFound("Gagal menghapus, index tidak valid.");

            listFilm.RemoveAt(idx);
            return Ok("Film berhasil dihapus.");
        }
    }
}