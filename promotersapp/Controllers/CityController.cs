using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using promotersapp.Services;
using promotersapp.ViewModels;

namespace promotersapp.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CityController(
             ICityService cityService,
            IMapper mapper
            )
        {
            _cityService = cityService;
            _mapper = mapper;
        }

        public IActionResult GetCities()
        {
            var cities = _cityService.GetAll();
            var citiesDto = cities.Select(city => _mapper.Map<CityDto>(city)).ToList();

            return Json(citiesDto);
        }

    }
}
