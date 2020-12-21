using System;
namespace promotersapp.ViewModels
{
    public class FirmDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Rating { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
