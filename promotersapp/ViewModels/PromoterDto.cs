using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class PromoterDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int CityId { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Description { get; set; }

        public virtual string City { get; set; }
        public virtual UserDto User { get; set; }
        public virtual ICollection<DiscussionDto> Discussions { get; set; }
        public virtual ICollection<PerkDto> Perks { get; set; }
        public virtual ICollection<PersonalDetailDto> PersonalDetails { get; set; }
        public virtual ICollection<ScheduleDto> Schedules { get; set; }
    }
}
