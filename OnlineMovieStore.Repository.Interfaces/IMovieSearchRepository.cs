using OnlineMovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repository.Interfaces
{
	public interface IMovieSearchRepository
    {
        void Add(MovieSearch movie);
        void Edit(MovieSearch movie);

        void Delete(MovieSearch movie);

        MovieSearch GetMovieSearchById(int id);

        MovieSearch GetMovieSearchByName(string name);

        MovieSearch GetMovieSearchByCountry(string country);


        IEnumerable<MovieSearch> GetAllMovieSearches();
    }
}
