using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using promotersapp.Models;
using promotersapp.Repositories;

namespace promotersapp.Services
{
    public class CityService : ICityService
    {
        private readonly IRepository<City> _cityRepository;

        public CityService(IRepository<City> cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IEnumerable<City> GetAll()
        {

            var promoters = _cityRepository.GetAll().ToList();

            return promoters;
        }
    }
}
