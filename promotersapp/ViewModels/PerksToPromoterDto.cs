using System;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class PerksToPromoterDto
    {
        public int Id { get; set; }
        public int PromoterId { get; set; }
        public int PerkId { get; set; }

        public virtual PerkDto Perk { get; set; }
        //public virtual Promoter Promoter { get; set; }
    }
}
