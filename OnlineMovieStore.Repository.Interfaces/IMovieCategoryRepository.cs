namespace OnlineMovieStore.Repository.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IMovieCategoryRepository
    {
        void Add(MovieCategory category);
        void Edit(MovieCategory category);

        void Delete(MovieCategory category);



        MovieCategory GetMovieCategoryById(int id);

        MovieCategory GetMovieCategoryByName(string name);
        IEnumerable<MovieCategory> GetAllMovieCategories(MovieCategory category);
    }
}
