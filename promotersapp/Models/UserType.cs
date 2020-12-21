using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class UserType : BaseEntity
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public string UserTypeName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
