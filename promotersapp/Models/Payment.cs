using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace promotersapp.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Value { get; set; }
        public bool? IsSubscribed { get; set; }
        public string PaymentCode { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Firm Firm { get; set; }
    }
}
