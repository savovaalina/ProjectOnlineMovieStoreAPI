

namespace OnlineMovieStore.Service.Interfaces
{
    using OnlineMovieStore.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IPhotoMovieService
    {
        void Add(PhotoMovie photo);
        void Edit(PhotoMovie photo);

        void Delete(PhotoMovie photo);

        PhotoMovie GetPhotoMovieById(int id);


        IEnumerable<PhotoMovie> GetAllPhotoMovies();

        IEnumerable<PhotoMovie> GetAllPhotoMovies(DateTime date);
        IEnumerable<PhotoMovie> GetAllPhotoMovies(bool isMain);
    }
}
