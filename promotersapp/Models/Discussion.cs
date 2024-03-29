﻿using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Discussion : BaseEntity
    {
        public Discussion()
        {
            Messages = new HashSet<Message>();
        }

        public int PromoterId { get; set; }
        public int FirmId { get; set; }

        public virtual Firm Firm { get; set; }
        public virtual Promoter Promoter { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
