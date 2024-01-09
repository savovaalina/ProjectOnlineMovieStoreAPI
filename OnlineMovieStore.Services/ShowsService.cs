

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
    public class ShowsService : IShowsService
    {
        private readonly IShowsRepository _showsRepository;

        public ShowsService(IShowsRepository showsRepository)
        {
            _showsRepository = showsRepository;
        }

        public void Add(Shows shows)
        {
            _showsRepository.Add(shows);
        }

        public void Delete(Shows shows)
        {
            _showsRepository.Delete(shows);
        }

        public void Edit(Shows shows)
        {
            _showsRepository.Edit(shows);
        }

        public IEnumerable<Shows> GetAllShows(Shows shows)
        {
            var result = _showsRepository.GetAllShows(shows);
            return result;
        }
            
        public Shows GetShowsById(int id)
        {
            var result = _showsRepository.GetShowsById(id);
            return result;
        }
    }
}
