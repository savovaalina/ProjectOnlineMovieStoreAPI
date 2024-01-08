

namespace OnlineMovieStore.Service.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IMovieService
    {
        void Add(Movie movie);
        void Edit(Movie movie);

        void Delete(Movie movie);

        Movie GetMovieById(int id);
        IEnumerable<Movie> GetAllMovies();

        IQueryable<Movie> GetAllMoviesQueryable();

        IEnumerable<Movie> GetAllMoviesByUser();
        IEnumerable<Movie> GetAllMoviesByUser(string userId);

        IEnumerable<Movie> GetAllMoviesByDateDescending();

        IEnumerable<Movie> GetAllMoviesByDateAscending();

        IEnumerable<Movie> GetAllMoviesFromToDateByUserId(string userId, DateTime from, DateTime to);

        IEnumerable<Movie> GetAllMoviesByPriceAscending();
        IEnumerable<Movie> GetAllMoviesByPriceDescending();

        IEnumerable<Movie> GetAllMovieByCountry(string country);

        IEnumerable<Movie> GetAllMovieByActor(string actorName);

        IEnumerable<Movie> GetAllMovieByProducer(string producerName);

        IEnumerable<Movie> GetTop5PopularMovies();

        IEnumerable<Movie> GetTopPopularMoviesByProducer(int producerId);

        //Important
        IEnumerable<Movie> GetAllMoviesWithFullRelationDate();


    }
}
