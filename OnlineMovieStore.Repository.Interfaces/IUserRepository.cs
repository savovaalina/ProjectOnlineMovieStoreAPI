﻿using OnlineMovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieStore.Repository.Interfaces
{
    public interface IUserRepository
    {
        void Add(User user);
        void Edit(User user);
        void Delete(User user);
        User GetUserById(string id);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        IEnumerable<User> GetUsersByCountry(string country);
        IEnumerable<User> GetUsersByCity(string city);
        IEnumerable<User> GetAllUsers();
    }
}
