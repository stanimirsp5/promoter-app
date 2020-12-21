using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Perk : BaseEntity
    {
        public Perk()
        {
            PerksToPromoters = new HashSet<PerksToPromoter>();
        }

        public string PerkName { get; set; }

        public virtual ICollection<PerksToPromoter> PerksToPromoters { get; set; }
    }
}
