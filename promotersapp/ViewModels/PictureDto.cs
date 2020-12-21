using System;
namespace promotersapp.ViewModels
{
    public class PictureDto
    {
        public int UserId { get; set; }
        public bool IsProfilePic { get; set; }
        public byte[] FileContent { get; set; }
        public string MimeType { get; set; }
        public string Title { get; set; }
    }
}
