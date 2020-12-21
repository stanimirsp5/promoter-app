using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class UserDto
    {
        public int UserTypeId { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public int FailedLogins { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Firm> Firms { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        //public virtual ICollection<Promoter> Promoters { get; set; }
    }
}
