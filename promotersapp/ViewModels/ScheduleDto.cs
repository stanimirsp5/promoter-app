using System;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int PromoterId { get; set; }
        public int WeekDayId { get; set; }
        public DateTime FreeFrom { get; set; }
        public DateTime FreeTo { get; set; }
        public DateTime Date { get; set; }
        public bool? IsStatic { get; set; }

        //public Promoter Promoter { get; set; }
        //public WeekDay PromoterNavigation { get; set; }
    }
}
