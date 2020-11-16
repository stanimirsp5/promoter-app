using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class User
    {
        public User()
        {
            Firms = new HashSet<Firm>();
            Pictures = new HashSet<Picture>();
            Promoters = new HashSet<Promoter>();
        }

        public int Id { get; set; }
        public int UserTypeId { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public int FailedLogins { get; set; }
        public bool IsLocked { get; set; }
        public bool IsDisabled { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Firm> Firms { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Promoter> Promoters { get; set; }
    }
}
