using System;
using System.Collections.Generic;

#nullable disable

namespace promotersapp.Models
{
    public partial class PersonalDetail : BaseEntity
    {
        public int PromoterId { get; set; }
        public string EyeColor { get; set; }
        public int? Height { get; set; }
        public string MotherLanguage { get; set; }
        public string ForeignLanguage { get; set; }
        public string ForeignLanguage2 { get; set; }
        public string ForeignLanguage3 { get; set; }

        public virtual Promoter Promoter { get; set; }
    }
}
