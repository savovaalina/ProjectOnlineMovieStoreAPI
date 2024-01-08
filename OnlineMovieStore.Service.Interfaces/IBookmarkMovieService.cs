

namespace OnlineMovieStore.Service.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IBookmarkMovieService
    {
        void Add(BookmarkMovie bookmark);
        void Edit(BookmarkMovie bookmark);

        void Delete(BookmarkMovie bookmark);

        BookmarkMovie GetBookmarkMovieById(int id);
        IEnumerable<BookmarkMovie> GetAllBookmarkMovies(BookmarkMovie bookmark);
    }
}
