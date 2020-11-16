using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsProfilePic { get; set; }
        public byte[] FileContent { get; set; }
        public string MimeType { get; set; }
        public string Title { get; set; }

        public virtual User User { get; set; }
    }
}
