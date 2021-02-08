using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using promotersapp.Models;
using promotersapp.Services;
using promotersapp.ViewModels;

namespace promotersapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(
           IAccountService accountService,
           IMapper mapper
           )
        {
            _accountService = accountService;
            _mapper = mapper;

        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserDto userDto)
        {
            // TODO doesn't seem very clear
            var user = _mapper.Map<User>(userDto);
             _accountService.Create(user);
            //var createdUserDto = _mapper.Map<UserDto>(createdUser);

            return Json(userDto);
        }
    }
}