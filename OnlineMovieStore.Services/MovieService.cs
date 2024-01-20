
namespace OnlineMovieStore.Services
{
    using OnlineMovieStore.Entities;
    using OnlineMovieStore.Repository.Interfaces;
    using OnlineMovieStore.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MovieService : IMovieService
    {

        private readonly IMovieRepository _movieRepository;

        public  MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.Delete(movie);

        }

        public void Edit(Movie movie)
        {
            _movieRepository.Edit(movie);
        }

        public IEnumerable<Movie> GetAllMovieByActor(string actorName)
        {
            var result = _movieRepository.GetAllMovieByActor(actorName);
            return result;
        }

        public IEnumerable<Movie> GetAllMovieByCountry(string country)
        {
            var result = _movieRepository.GetAllMovieByCountry(country);
            return result;
        }

        public IEnumerable<Movie> GetAllMovieByProducer(string producerName)
        {
            var result = _movieRepository.GetAllMovieByProducer(producerName);
            return result;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateAscending()
        {
            var result = _movieRepository.GetAllMoviesByDateAscending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByDateDescending()
        {
            var result = _movieRepository.GetAllMoviesByDateDescending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceAscending()
        {
            var result = _movieRepository.GetAllMoviesByPriceAscending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByPriceDescending()
        {
            var result = _movieRepository.GetAllMoviesByPriceDescending();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUser()
        {
            var result = _movieRepository.GetAllMoviesByUser();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesByUserId(string userId)
        {
            var result = _movieRepository.GetAllMoviesByUserId(userId);
            return result;

        }

        public IEnumerable<Movie> GetAllMoviesFromToDateByUserId(string userId, DateTime from, DateTime to)
        {
            var result = _movieRepository.GetAllMoviesFromToDateByUserId(userId, from, to);
            return result;
        }

        public IQueryable<Movie> GetAllMoviesQueryable()
        {
            var result = _movieRepository.GetAllMoviesQueryable();
            return result;
        }

        public IEnumerable<Movie> GetAllMoviesWithFullRelationDate()
        {
            var result = _movieRepository.GetAllMoviesWithFullRelationDate();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            //first option
            var result = _movieRepository.GetMovieById(id);
            return result;

            //second option
             //return _movieRepository.GetMovieById(id);
            
        }

        

        public IEnumerable<Movie> GetTop5PopularMovies()
        {
            var result = _movieRepository.GetTop5PopularMovies();
            return result;
        }

        public IEnumerable<Movie> GetTopPopularMoviesByProducer(int producerId)
        {
            var result = _movieRepository.GetTopPopularMoviesByProducer(producerId);
            return result;
        }
    }
}
