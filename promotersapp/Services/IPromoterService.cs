using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.Services
{
    public interface IPromoterService
    {
        IEnumerable<Promoter> GetWithAllProperties();
        IEnumerable<Promoter> GetByCity(int cityId);
    }
}
