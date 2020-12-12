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

        // GET: Search/GetPromoters?cityID={cityID}
        public IActionResult GetPromoters(string cityID)
        {

            var promoters = from p in _context.Promoters
                            select p;

            if (!String.IsNullOrEmpty(cityID)) {
                int id;
                int.TryParse(cityID, out id);
                promoters = promoters.Where(p => p.CityId == id);
            }

            

            return Json(promoters.ToList());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
