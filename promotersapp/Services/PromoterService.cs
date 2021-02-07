using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using promotersapp.Models;
using promotersapp.Repositories;

namespace promotersapp.Services
{
    public class PromoterService : IPromoterService
    {
        private readonly IRepository<Promoter> _promoterRepository;

        public PromoterService(IRepository<Promoter> promoterRepository)
        {
            _promoterRepository = promoterRepository;
        }


        public IEnumerable<Promoter> GetWithAllProperties()
        {
            var promoters = _promoterRepository.GetAll()
                .Include(p => p.Schedules)
                .Include(p => p.City)
                .Include(p => p.Discussions)
                .Include(p => p.PerksToPromoters).ThenInclude(pe => pe.Perk)
                .Include(p => p.PersonalDetails)
                .Include(p => p.User).ToList();

            return promoters;
        }

        public IEnumerable<Promoter> GetByCity(int cityId)
        {

            var promoters = _promoterRepository.GetAll().Where(p => p.CityId == cityId);

            return promoters;
        }

    }
}
