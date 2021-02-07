using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.Services
{
    public interface ICityService
    {
        IEnumerable<City> GetAll();
    }
}
