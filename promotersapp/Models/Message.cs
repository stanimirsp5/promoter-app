﻿using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Message : BaseEntity
    {
        public int DiscussionId { get; set; }
        public string Message1 { get; set; }
        public DateTime Date { get; set; }
        public bool IsFirm { get; set; }
        public bool IsSeen { get; set; }
        public bool? Notify { get; set; }

        public virtual Discussion Discussion { get; set; }
    }
}
