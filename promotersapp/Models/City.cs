using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class City
    {
        public City()
        {
            Firms = new HashSet<Firm>();
            Promoters = new HashSet<Promoter>();
        }

        public int Id { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Firm> Firms { get; set; }
        public virtual ICollection<Promoter> Promoters { get; set; }
    }
}
