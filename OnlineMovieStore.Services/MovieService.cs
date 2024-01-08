

namespace OnlineMovieStore.Services
{
    using OnlineMovieStore.Entities;
    using OnlineMovieStore.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MovieService : IMovieService
    {
        public void Add(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void Edit(Movie movie)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMovieByActor(string actorName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMovieByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMovieByProducer(string producerName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByDateAscending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByDateDescending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByPriceAscending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByPriceDescending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByUser()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesByUser(string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesFromToDateByUserId(string userId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAllMoviesWithFullRelationDate()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetTop5PopularMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetTopPopularMoviesByProducer(int producerId)
        {
            throw new NotImplementedException();
        }
    }
}
