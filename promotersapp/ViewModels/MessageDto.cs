using System;
namespace promotersapp.ViewModels
{
    public class MessageDto
    {
        public int Id { get; set; }
        public int DiscussionId { get; set; }
        public string Message1 { get; set; }
        public DateTime Date { get; set; }
        public bool IsFirm { get; set; }
        public bool IsSeen { get; set; }
        public bool? Notify { get; set; }
    }
}
