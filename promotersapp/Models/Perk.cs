using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Perk
    {
        public Perk()
        {
            PerksToPromoters = new HashSet<PerksToPromoter>();
        }

        public int Id { get; set; }
        public string PerkName { get; set; }

        public virtual ICollection<PerksToPromoter> PerksToPromoters { get; set; }
    }
}
