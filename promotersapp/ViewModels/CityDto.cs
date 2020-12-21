using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class CityDto
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Firm> Firms { get; set; }
        public virtual ICollection<Promoter> Promoters { get; set; }
    }
}
