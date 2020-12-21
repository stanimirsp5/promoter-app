using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class UserTypeDto
    {
        public string Id { get; set; }
        public string UserTypeName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
