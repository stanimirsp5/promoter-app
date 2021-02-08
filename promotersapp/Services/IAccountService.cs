using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.Services
{
    public interface IAccountService
    {
        User Create(User user);
    }
}
