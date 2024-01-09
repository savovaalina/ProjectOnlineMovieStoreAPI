﻿

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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User user)
        {
           _userRepository.Add(user);
        }

        public void Delete(User user)
        {
            _userRepository.Delete(user);
        }

        public void Edit(User user)
        {
            _userRepository.Edit(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = _userRepository.GetAllUsers();
            return result;
        }

        public User GetUserByEmail(string email)
        {
            var result = _userRepository.GetUserByEmail(email);
            return result;
        }

        public User GetUserById(string id)
        {
            var result = _userRepository.GetUserById(id);
            return result;
        }

        public User GetUserByUsername(string username)
        {
            var result = _userRepository.GetUserByUsername(username);
            return result;
        }

        public IEnumerable<User> GetUsersByCity(string city)
        {
            var result = _userRepository.GetUsersByCity(city);
            return result;
        }

        public IEnumerable<User> GetUsersByCountry(string country)
        {
            var result = _userRepository.GetUsersByCountry(country);
            return result;
        }
    }
}
