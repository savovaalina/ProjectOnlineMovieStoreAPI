using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieStore.Entities;
using OnlineMovieStore.Service.Interfaces;

namespace ProjectOnlineMovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("Movies")]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            var movies = _movieService.GetAllMovies();
            return Ok(movies);
        }

    }
}
