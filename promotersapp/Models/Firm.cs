using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace promotersapp.Models
{
    public partial class Firm : BaseEntity
    {
        public Firm()
        {
            Discussions = new HashSet<Discussion>();
            Payments = new HashSet<Payment>();
        }

        public int UserId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Rating { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Discussion> Discussions { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
