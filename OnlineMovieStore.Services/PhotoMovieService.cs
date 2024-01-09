

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
    public class PhotoMovieService : IPhotoMovieService
    {
        private readonly IPhotoMovieRepository _photoMovieRepository;

        public PhotoMovieService(IPhotoMovieRepository photoMovieRepository)
        {
            _photoMovieRepository = photoMovieRepository;
        }

        public void Add(PhotoMovie photo)
        {
            _photoMovieRepository.Add(photo);
        }

        public void Delete(PhotoMovie photo)
        {
            _photoMovieRepository.Delete(photo);
        }

        public void Edit(PhotoMovie photo)
        {
            _photoMovieRepository.Edit(photo);
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies()
        {
            var result = _photoMovieRepository.GetAllPhotoMovies();
            return result;
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies(DateTime date)
        {
            var result = _photoMovieRepository.GetAllPhotoMovies(date);
            return result;
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies(bool isMain)
        {
            var result = _photoMovieRepository.GetAllPhotoMovies();
            return result;
        }

        public PhotoMovie GetPhotoMovieById(int id)
        {
            var result = _photoMovieRepository.GetPhotoMovieById(id);
            return result;
        }
    }
}
