﻿

namespace OnlineMovieStore.Repositories
{
    using OnlineMovieStore.Entities;
    using OnlineMovieStore.Repository.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class PhotoMovieRepository : IPhotoMovieRepository
    {
        public void Add(PhotoMovie photo)
        {
            throw new NotImplementedException();
        }

        public void Delete(PhotoMovie photo)
        {
            throw new NotImplementedException();
        }

        public void Edit(PhotoMovie photo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhotoMovie> GetAllPhotoMovies(bool isMain)
        {
            throw new NotImplementedException();
        }

        public PhotoMovie GetPhotoMovieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
