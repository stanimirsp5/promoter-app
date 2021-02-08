using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class UserDto
    {
       
        //public bool EmailConfirmed { get; set; } // needed?
        //public int FailedLogins { get; set; }// needed?

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

        //public virtual UserType UserType { get; set; }
        //public virtual ICollection<Firm> Firms { get; set; }
        //public virtual ICollection<Picture> Pictures { get; set; }
        //public virtual ICollection<Promoter> Promoters { get; set; }
    }
}
