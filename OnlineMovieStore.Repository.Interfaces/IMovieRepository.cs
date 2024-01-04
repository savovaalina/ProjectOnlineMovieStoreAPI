
namespace OnlineMovieStore.Repository.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IMovieRepository
    {

        void Add(Movie movie);
        void Edit(Movie movie);

        void Delete(Movie movie);

        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();
    }
}
