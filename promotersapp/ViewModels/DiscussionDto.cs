using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class DiscussionDto
    {
        public int Id { get; set; }
        public int PromoterId { get; set; }
        public int FirmId { get; set; }

        public virtual Firm Firm { get; set; }
        //public virtual Promoter Promoter { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
