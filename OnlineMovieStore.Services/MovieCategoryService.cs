

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
    public class MovieCategoryService : IMovieCategoryService
    {

        private readonly IMovieCategoryRepository _movieCategoryRepository;

        public MovieCategoryService(IMovieCategoryRepository movieCategoryRepository)
        {
            _movieCategoryRepository = movieCategoryRepository;
        }

        public void Add(MovieCategory category)
        {
            _movieCategoryRepository.Add(category); 
        }

        public void Delete(MovieCategory category)
        {
            _movieCategoryRepository.Delete(category);
        }

        public void Edit(MovieCategory category)
        {
            _movieCategoryRepository.Edit(category);
        }

        public IEnumerable<MovieCategory> GetAllMovieCategories(MovieCategory category)
        {
            var result= _movieCategoryRepository.GetAllMovieCategories(category);
            return result;
        }

        public MovieCategory GetMovieCategoryById(int id)
        {
            var result = _movieCategoryRepository.GetMovieCategoryById(id);
            return result;
        }

        public MovieCategory GetMovieCategoryByName(string name)
        {
            var result = _movieCategoryRepository.GetMovieCategoryByName(name);
            return result;
        }
    }
}
