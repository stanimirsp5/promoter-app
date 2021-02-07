using System;
using Microsoft.AspNetCore.Mvc;

namespace promotersapp.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
        }

        public IActionResult Promoter()
        {

            return View();
        }

        public IActionResult Dashboard()
        {

            return View();
        }

    }
}
