using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using promotersapp.Contexts;
using promotersapp.Models;
using promotersapp.Repositories;
using promotersapp.ViewModels;
using AutoMapper;
namespace promotersapp.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<City> _cityRepository;
        private readonly IRepository<Promoter> _promoterRepository;
        private readonly IMapper _mapper;

        public SearchController(
            ILogger<HomeController> logger,
            IRepository<City> cityRepository,
            IRepository<Promoter> promoterRepository,
            IMapper mapper
        ){
            _logger = logger;
            _promoterRepository = promoterRepository;
            _cityRepository = cityRepository;
            _mapper = mapper;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCities()
        {
            var getAll = _cityRepository.GetAll();

            return Json(getAll);
        }

        // GET: Search/GetPromoters?cityID={cityID}
        public IActionResult GetPromoters(string cityID)
        {
            var promoters = _promoterRepository.GetAll()
                .Include(p => p.Schedules)
                .Include(p => p.City)
                .Include(p => p.Discussions)
                .Include(p => p.PerksToPromoters).ThenInclude(pe => pe.Perk)
                .Include(p => p.PersonalDetails)
                .Include(p => p.User)
                .Select(p => _mapper.Map<PromoterDto>(p)).ToList();

            return Json(promoters);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
