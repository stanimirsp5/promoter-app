using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public int PromoterId { get; set; }
        public int WeekDayId { get; set; }
        public DateTime FreeFrom { get; set; }
        public DateTime FreeTo { get; set; }
        public DateTime Date { get; set; }
        public bool? IsStatic { get; set; }

        public virtual Promoter Promoter { get; set; }
        public virtual WeekDay PromoterNavigation { get; set; }
    }
}
