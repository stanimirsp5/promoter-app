using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using promotersapp.Models;
using promotersapp.Repositories;

namespace promotersapp.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<User> _userRepository;

        public AccountService(
            IRepository<User> userRepository
        )
        {
            _userRepository = userRepository;
        }


        public User Create(User user)
        {
            _userRepository.Create(user);

            return user;
        }
    }
}
