using OnlineMovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repository.Interfaces
{
	public interface IShowsRepository
    {
        void Add(Shows shows);
        void Edit(Shows shows);

        void Delete(Shows shows);

        Shows GetShowsById(int id);
        IEnumerable<Shows> GetAllShows(Shows shows);
    }
}
