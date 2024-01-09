

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
    public class BookmarkMovieService : IBookmarkMovieService
    {
        private readonly IBookmarkMovieRepository _bookmarkMovieRepository;

        public BookmarkMovieService(IBookmarkMovieRepository bookmarkMovieRepository)
        {
            _bookmarkMovieRepository = bookmarkMovieRepository;
        }

        public void Add(BookmarkMovie bookmark)
        {
            _bookmarkMovieRepository.Add(bookmark); 
        }

        public void Delete(BookmarkMovie bookmark)
        {
            _bookmarkMovieRepository.Delete(bookmark);
        }

        public void Edit(BookmarkMovie bookmark)
        {
            _bookmarkMovieRepository.Edit(bookmark);
        }

        public IEnumerable<BookmarkMovie> GetAllBookmarkMovies(BookmarkMovie bookmark)
        {
            var result = _bookmarkMovieRepository.GetAllBookmarkMovies(bookmark);
            return result;
        }

        public BookmarkMovie GetBookmarkMovieById(int id)
        {
            var result = _bookmarkMovieRepository.GetBookmarkMovieById(id);
            return result;
        }
    }
}
