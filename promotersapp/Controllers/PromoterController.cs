using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using promotersapp.Services;
using promotersapp.ViewModels;

namespace promotersapp.Controllers
{
    public class PromoterController : Controller
    {
        private readonly IPromoterService _promoterService;
        private readonly IMapper _mapper;

        public PromoterController(
            IPromoterService promoterService,
            IMapper mapper
            )
        {
            _promoterService = promoterService;
            _mapper = mapper;

        }


        public IActionResult GetPromotersWithAllProperties()
        {
            var promoters = _promoterService.GetWithAllProperties();
            var promotersDto = promoters.Select(p => _mapper.Map<PromoterDto>(p));

            return Json(promotersDto);
        }

        public IActionResult GetPromotersByCity(int cityId)
        {
            var promoters = _promoterService.GetByCity(cityId);
            var promotersDto = promoters.Select(p => _mapper.Map<PromoterDto>(p));

            return Json(promotersDto);
        }

    }
}
