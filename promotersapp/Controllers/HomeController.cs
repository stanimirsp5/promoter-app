using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using promotersapp.Contexts;
using promotersapp.Models;
using promotersapp.Repositories;

namespace promotersapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepository<City> _cityRepository;

        public HomeController(
            ILogger<HomeController> logger,
            PromoterDbContext context,
           IRepository<City> cityRepository

            )
        {
            _logger = logger;
            _cityRepository = cityRepository;

        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {

            return View();
        }

        public IActionResult GetOne(int id)
        {
            var city = _cityRepository.GetOne(id);


            return Json(city);
        }
        public IActionResult GetCities()
        {

            var getAll = _cityRepository.GetAll();

            return Json(getAll);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
