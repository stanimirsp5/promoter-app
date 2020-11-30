using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using promotersapp.Contexts;
using promotersapp.Models;

namespace promotersapp.Controllers
{
    public class SearchController : Controller
    {
        private readonly ILogger<SearchController> _logger;
        private readonly PromoterDbContext _context;

        public SearchController(
            ILogger<SearchController> logger,
            PromoterDbContext context

            )
        {
            _logger = logger;
            _context = context;

        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCities()
        {
            var cityList = _context.Cities.AsEnumerable();


            return Json(cityList);
        }

        public IActionResult FindPromoter(string city)
        {
            var promoterList = _context.Promoters.Single(promoter => promoter.City.CityName == city);
            
            return Json(promoterList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
