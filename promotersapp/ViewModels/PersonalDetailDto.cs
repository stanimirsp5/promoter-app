using System;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class PersonalDetailDto
    {
        public int Id { get; set; }
        public int PromoterId { get; set; }
        public string EyeColor { get; set; }
        public int? Height { get; set; }
        public string MotherLanguage { get; set; }
        public string ForeignLanguages { get; set; }

        //public virtual Promoter Promoter { get; set; }
    }
}
