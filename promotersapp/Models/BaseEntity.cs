using System;
namespace promotersapp.Models
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        //public DateTime CreatedOn { get; set; } = DateTime.Now;
        //public DateTime UpdatedOn { get; set; } = DateTime.Now;

    }
}
