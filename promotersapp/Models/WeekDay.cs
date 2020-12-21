using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class WeekDay : BaseEntity
    {
        public WeekDay()
        {
            Schedules = new HashSet<Schedule>();
        }

        public string Weekday1 { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
