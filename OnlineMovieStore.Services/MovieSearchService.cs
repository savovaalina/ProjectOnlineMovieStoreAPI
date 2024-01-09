

namespace OnlineMovieStore.Services
{
    using OnlineMovieStore.Entities;
    using OnlineMovieStore.Repository.Interfaces;
    using OnlineMovieStore.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Metrics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class MovieSearchService : IMovieSearchService
    {
        private readonly IMovieSearchRepository _movieSearchRepository;

        public MovieSearchService(IMovieSearchRepository movieSearchRepository)
        {
            _movieSearchRepository = movieSearchRepository;
        }

        public void Add(MovieSearch movie)
        {
            _movieSearchRepository.Add(movie);
        }

        public void Delete(MovieSearch movie)
        {
            _movieSearchRepository.Delete(movie);
        }

        public void Edit(MovieSearch movie)
        {
            _movieSearchRepository.Edit(movie);
        }

        public IEnumerable<MovieSearch> GetAllMovieSearches()
        {
            var result = _movieSearchRepository.GetAllMovieSearches();
            return result;
        }

        public MovieSearch GetMovieSearchByCountry(string country)
        {
            var result = _movieSearchRepository.GetMovieSearchByCountry(country);
            return result;
        }

        public MovieSearch GetMovieSearchById(int id)
        {
            var result = _movieSearchRepository.GetMovieSearchById(id);
            return result;
        }

        public MovieSearch GetMovieSearchByName(string name)
        {
            var result = _movieSearchRepository.GetMovieSearchByName(name);
            return result;
        }
    }
}
