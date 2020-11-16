using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Promoter
    {
        public Promoter()
        {
            Discussions = new HashSet<Discussion>();
            PerksToPromoters = new HashSet<PerksToPromoter>();
            PersonalDetails = new HashSet<PersonalDetail>();
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<PerksToPromoter> PerksToPromoters { get; set; }
        public virtual ICollection<PersonalDetail> PersonalDetails { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
