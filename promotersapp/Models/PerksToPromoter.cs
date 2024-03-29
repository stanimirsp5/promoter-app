﻿using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class PerksToPromoter : BaseEntity
    {
        public int PromoterId { get; set; }
        public int PerkId { get; set; }

        public virtual Perk Perk { get; set; }
        public virtual Promoter Promoter { get; set; }
    }
}
